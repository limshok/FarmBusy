using Systems;

namespace DependencyManagement
{
    public class GlobalContext : IContext
    {
        public GlobalContext()
        {
            SystemManager = new SystemManager();
        }

        public GlobalContext(IContext context)
        {
            SystemManager = context.SystemManager;
        }
        
        public SystemManager SystemManager { get; }
    }
}