using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenant.DemoApp.Queries.Validators
{
    public class GetAllTenantQueryValidator : AbstractValidator<GetAllTenantQuery>
    {
        public GetAllTenantQueryValidator()
        {

        }
    }
}
