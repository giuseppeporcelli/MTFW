using System;

namespace MTFW.Core
{
    /// <summary>
    /// Defines methods to manage tenants.
    /// </summary>
    public interface ITenantService
    {
        Tenant GetTenant(Guid tenantGuid);
    }
}
