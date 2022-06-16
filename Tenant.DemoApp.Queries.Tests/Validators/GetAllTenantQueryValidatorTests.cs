using FluentValidation.TestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tenant.DemoApp.Queries.Validators;

namespace Tenant.DemoApp.Queries.Tests.Validators
{
    [TestClass]
    public class GetAllTenantQueryValidatorTests
    {
        private GetAllTenantQueryValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new GetAllTenantQueryValidator();
        }

        [TestMethod]
        public void Should_Not_Have_Validation_Error_Message()
        {
            var query = new GetAllTenantQuery();
            var result = validator.TestValidate(query);
            Assert.AreEqual(true,result.IsValid);
        }
    }
}
