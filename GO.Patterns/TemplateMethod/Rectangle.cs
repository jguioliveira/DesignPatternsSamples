using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO.Patterns.TemplateMethod.Figure
{
    public class Rectangle : Figure
    {
        public double SideOne { get; private set; }

        public double SideTwo { get; private set; }

        public Rectangle(double sideOne, double sideTwo)
        {
            SideOne = sideOne;
            SideTwo = sideTwo;
        }

        public override double GetArea()
        {
            return SideOne * SideTwo;
        }

        public override double GetPerimeter()
        {
            return (SideOne * 2) + (SideTwo * 2);
        }

        public override string ToString()
        {
            return "Rectangle";
        }
    }
}
