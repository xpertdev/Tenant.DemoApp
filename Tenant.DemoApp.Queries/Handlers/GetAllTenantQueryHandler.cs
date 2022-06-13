using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tenant.DemoApp.Queries.Dtos;

namespace Tenant.DemoApp.Queries.Handlers
{
    /// <summary>
    /// Get all tenant query handler
    /// </summary>
    public class GetAllTenantQueryHandler : IQueryHandler<GetAllTenantQuery, IEnumerable<TenantDto>>
    {
        private readonly ILogger<GetAllTenantQueryHandler> logger;

        public GetAllTenantQueryHandler(ILogger<GetAllTenantQueryHandler> logger)
        {
            this.logger = logger;
        }

        public async Task<IEnumerable<TenantDto>> HandleAsync(GetAllTenantQuery query)
        {
            logger.LogInformation($"Starting {nameof(GetAllTenantQueryHandler)}");

            //Handle query and return data
            return new List<TenantDto>
            {
                new TenantDto{ TenantId=1, Identifier="Tenant1", Name="Tenant1"},
                new TenantDto{ TenantId=2, Identifier="Tenant2", Name="Tenant2"}
            };
        }
    }
}
