using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO.Patterns.FactoryMethod
{
    public class Module
    {
        public Module(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
