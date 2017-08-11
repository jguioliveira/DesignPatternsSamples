using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO.Patterns.FactoryMethod
{
    public abstract class User
    {
        protected User()
        {
            CreatePermissions();
        }

        protected abstract void CreatePermissions();

        protected abstract void LoadModules();

        protected PermissionCollection Permissions { get; set; }

        protected ModuleCollection Modules { get; set; }

        public PermissionCollection GetPermissions()
        {
            return Permissions;
        }

        public ModuleCollection GetModules()
        {
            return Modules;
        }

        public static User CreateUser(UserType userType)
        {
            switch (userType)
            {
                case UserType.Administrator:
                    return new Administrator();
                case UserType.Supervisor:
                    return new Supervisor();
                default:
                    throw new ArgumentException("Invalid UserType");
            }
        }
    }

    public enum UserType
    {
        Administrator,
        Supervisor
    }
}
