using System;
using System.Collections.Generic;
using System.Linq;

namespace MTFW.Core.Internal
{
    /// <summary>
    /// Represents the tenant service.
    /// </summary>
    public class TenantService : ITenantService
    {
        private IList<Tenant> _tenants;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public TenantService()
        {
            _tenants = new List<Tenant>();
        }

        Tenant ITenantService.GetTenant(Guid tenantGuid)
        {
            return _tenants.Where(t => t.TenantGuid == tenantGuid).FirstOrDefault();
        }
    }
}
