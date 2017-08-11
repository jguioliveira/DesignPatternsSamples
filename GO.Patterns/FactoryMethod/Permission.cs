using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO.Patterns.FactoryMethod
{
    public abstract class Permission
    {
        IList<Object>Entities { get; set; }

        public abstract void DoWork();
    }

    public class CreatePermission : Permission
    {
        public CreatePermission()
        {
            Console.WriteLine("This user has permission to create an entity.");
        }

        public override void DoWork()
        {
            throw new NotImplementedException();
        }
    }

    public class ReadPermission : Permission
    {
        public ReadPermission()
        {
            Console.WriteLine("This user has permission to read an entity.");
        }

        public override void DoWork()
        {
            throw new NotImplementedException();
        }
    }

    public class UpdatePermission : Permission
    {
        public UpdatePermission()
        {
            Console.WriteLine("This user has permission to update an entity.");
        }

        public override void DoWork()
        {
            throw new NotImplementedException();
        }
    }

    public class DeletePermission : Permission
    {
        public DeletePermission()
        {
            Console.WriteLine("This user has permission to delete an entity.");
        }

        public override void DoWork()
        {
            throw new NotImplementedException();
        }
    }
}
