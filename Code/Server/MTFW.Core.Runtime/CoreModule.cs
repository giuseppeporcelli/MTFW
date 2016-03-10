using Ninject.Modules;

namespace MTFW.Core.Runtime
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
