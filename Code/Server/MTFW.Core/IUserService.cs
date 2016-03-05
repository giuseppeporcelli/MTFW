using System;

namespace MTFW.Core
{
    public interface IUserService
    {
        User GetUser(Guid tenantGuid, Guid userGuid);
    }
}
