using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Triangle : Figure
    {
        private double side;

        public Triangle(double side) : base("Треугольник")
        {
            this.side = side;
        }

        public double Side
        {
            get => side;
            set => side = value;
        }

        public override double Area() => (Math.Sqrt(3) / 4) * side * side;

        public override double Perimeter() => 3 * side;

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Сторона: {Side}");
        }
    }
}
