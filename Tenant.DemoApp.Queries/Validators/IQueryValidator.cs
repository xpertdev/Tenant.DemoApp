using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenant.DemoApp.Queries.Validators
{
    public interface IQueryValidator
    {
        bool Validate<T>(T request, FluentValidation.IValidator<T> validator) where T : class;
    }
}
