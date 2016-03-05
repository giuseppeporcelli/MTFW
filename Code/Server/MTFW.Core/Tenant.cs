using System;

namespace MTFW.Core
{
    /// <summary>
    /// Represents a tenant.
    /// </summary>
    public class Tenant
    {
        /// <summary>
        /// Gets or sets the tenant identifier.
        /// </summary>
        /// <value>The tenant identifier.</value>
        public Guid TenantGuid { get; set; }

        /// <summary>
        /// Gets or sets the tenant name.
        /// </summary>
        /// <value>The tenant name.</value>
        public string Name { get; set; }
    }
}
