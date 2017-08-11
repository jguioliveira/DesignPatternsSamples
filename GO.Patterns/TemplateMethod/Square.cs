using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO.Patterns.TemplateMethod.Figure
{
    public class Square : Figure
    {
        public double Side { get; private set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double GetArea()
        {
            return Side * Side;
        }

        public override double GetPerimeter()
        {
            return Side * 4;
        }

        public override string ToString()
        {
            return "Square";
        }
    }
}
