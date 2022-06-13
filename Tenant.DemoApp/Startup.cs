using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tenant.DemoApp.Queries;
using Tenant.DemoApp.Queries.Dtos;
using Tenant.DemoApp.Queries.Handlers;
using Tenant.DemoApp.Queries.Validators;

[assembly: FunctionsStartup(typeof(Tenant.DemoApp.Startup))]
namespace Tenant.DemoApp
{
    /// <summary>
    /// Startup
    /// </summary>
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddLogging();
            builder.Services.AddTransient<IQueryValidator, QueryValidator>();
            builder.Services.AddTransient<IQueryHandler<GetAllTenantQuery, IEnumerable<TenantDto>>, GetAllTenantQueryHandler>();
        }
    }
}
