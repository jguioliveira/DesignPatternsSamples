using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO.Patterns.FactoryMethod
{
    public class Administrator : User
    {
        protected override void CreatePermissions()
        {
            Permissions = new PermissionCollection { new CreatePermission(), new ReadPermission(), new UpdatePermission(), new DeletePermission() };
        }

        protected override void LoadModules()
        {
            Modules = new ModuleCollection { new Module("User"), new Module("Module"), new Module("Permission"), new Module("Client"), new Module("Product") };
        }
    }
}
