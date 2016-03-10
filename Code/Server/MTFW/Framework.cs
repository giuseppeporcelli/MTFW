using MTFW.Core.Runtime;
using Ninject;

namespace MTFW
{
    public class Framework
    {
        private static StandardKernel _kernel;

        public static void Start()
        {
            _kernel = new StandardKernel(new CoreModule());
        }

        public static StandardKernel Kernel
        {
            get { return _kernel; }
        }
    }
}
