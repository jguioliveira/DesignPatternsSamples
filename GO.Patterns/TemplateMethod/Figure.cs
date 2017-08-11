using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO.Patterns.TemplateMethod.Figure
{
    public abstract class Figure
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();

        public void ShowInfo()
        {
            Console.WriteLine("Figure: {0}", this.ToString());
            Console.WriteLine("Figure Area: {0}", this.GetArea());
            Console.WriteLine("Figure Perimeter: {0}", this.GetPerimeter());
        }

        public override string ToString()
        {
            return "Figure";
        }
    }
}
