using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Tenant.DemoApp.Queries.Handlers;
using Tenant.DemoApp.Queries;
using Tenant.DemoApp.Queries.Dtos;
using System.Collections.Generic;
using Tenant.DemoApp.Queries.Validators;

namespace Tenant.DemoApp.Functions
{
    public class GetAllTenantWebHook
    {
        #region private fields
        private readonly ILogger<GetAllTenantWebHook> logger;
        private readonly IQueryValidator validator;
        private readonly IQueryHandler<GetAllTenantQuery, IEnumerable<TenantDto>> handler;
        #endregion

        #region ctors
        public GetAllTenantWebHook(ILogger<GetAllTenantWebHook> logger,
            IQueryValidator validator,
            IQueryHandler<GetAllTenantQuery, IEnumerable<TenantDto>> handler)
        {
            this.logger = logger;
            this.handler = handler;
            this.validator = validator;
        }
        #endregion

        #region azure function

        [FunctionName(nameof(GetAllTenantWebHook))]
        public async Task<IActionResult> RunAsync(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req)
        {
            try
            {
                var query = new GetAllTenantQuery();

                if (validator.Validate<GetAllTenantQuery>(query, new GetAllTenantQueryValidator()))
                {
                    var response = await handler.HandleAsync(query);

                    return new OkObjectResult(response);
                }
                return new OkObjectResult("no item found");
            }
            catch (Exception ex)
            {
                logger.LogError($"Exception while processing{nameof(GetAllTenantWebHook)}," +
                    $" Exception Message:{ex.Message}, StackTrace:{ex.StackTrace}");
                throw;
            }
        }
        #endregion
    }
}
