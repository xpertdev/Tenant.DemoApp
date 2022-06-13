using Newtonsoft.Json;


namespace Tenant.DemoApp.Queries.Dtos
{
    public class GetAllTenantDto
    {
        /// <summary>
        /// Tenants
        /// </summary>
        [JsonProperty("Tenants")]
        public IEnumerable<TenantDto> Tenants { get; set; }
    }
}
