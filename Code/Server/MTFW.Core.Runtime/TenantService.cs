using MTFW.Core.Runtime.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTFW.Core.Runtime
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

            using (MTWFDbContext context = new MTWFDbContext())
            {
                context.Tenants.Add(new Tenant()
                {
                    Name = "Tenant di prova",
                    TenantGuid = Guid.NewGuid()
                });
                context.SaveChanges();

                var tenants = context.Tenants.ToList();
            }            
        }

        Tenant ITenantService.GetTenant(Guid tenantGuid)
        {
            return _tenants.Where(t => t.TenantGuid == tenantGuid).FirstOrDefault();
        }
    }
}
