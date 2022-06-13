using Newtonsoft.Json;


namespace Tenant.DemoApp.Queries.Dtos
{
    /// <summary>
    /// Tenant
    /// </summary>
    public class TenantDto
    {
        /// <summary>
        /// Tenant Id
        /// </summary>
        [JsonProperty("TenantId")]
        public int TenantId { get; set; }

        /// <summary>
        /// Identifier
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Tenant name
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}
