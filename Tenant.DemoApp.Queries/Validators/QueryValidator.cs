using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenant.DemoApp.Queries.Validators
{
    public class QueryValidator : IQueryValidator
    {
        private readonly ILogger<QueryValidator> logger;

        public QueryValidator(ILogger<QueryValidator> logger)
        {
            this.logger = logger;
        }
        public bool Validate<T>(T request, FluentValidation.IValidator<T> validator) where T : class
        {
            bool result = false;
            if (request == null)
            {
                logger.LogWarning($"{typeof(T).FullName} was passed null, request must contain data. Throwing ValidationException");
            }
            else
            {
                var validationResult = validator.Validate(request);
                if (!validationResult.IsValid)
                {
                    logger.LogWarning($"{typeof(T).FullName} failed validation, request invalid. Validation Errors:{string.Join(";", validationResult.Errors)}");
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
