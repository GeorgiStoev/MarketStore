using Market_Store.Core;
using Market_Store.Core.Contracts;

namespace Market_Store
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();

            engine.Run();
        }
    }
}
