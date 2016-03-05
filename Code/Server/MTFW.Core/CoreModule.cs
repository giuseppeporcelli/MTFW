using MTFW.Core.Internal;
using Ninject.Modules;

namespace MTFW.Core
{
    public class CoreModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ITenantService>().ToConstant(new TenantService());
            this.Bind<IUserService>().ToConstant(new UserService());
        }
    }
}
