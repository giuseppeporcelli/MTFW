using Ninject;
using System;

namespace MTFW.Core.Internal
{
    public class UserService : IUserService
    {
        [Inject]
        public ITenantService TenantService { get; set; }

        User IUserService.GetUser(Guid tenantGuid, Guid userGuid)
        {
            Tenant tenant = TenantService.GetTenant(tenantGuid);
            return new User() { UserGuid = Guid.Empty };
        }
    }
}
