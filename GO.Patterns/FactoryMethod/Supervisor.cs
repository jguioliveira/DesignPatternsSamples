using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO.Patterns.FactoryMethod
{
    public class Supervisor : User
    {
        protected override void CreatePermissions()
        {
            Permissions = new PermissionCollection { new ReadPermission(), new UpdatePermission()};
        }

        protected override void LoadModules()
        {
            Modules = new ModuleCollection { new Module("Client"), new Module("Product") };
        }
    }
}
