using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Square : Figure
    {
        private double side;

        public Square(double side) : base("Квадрат")
        {
            this.side = side;
        }

        public double Side
        {
            get => side;
            set => side = value;
        }

        public override double Area() => side * side;

        public override double Perimeter() => 4 * side;

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Сторона: {Side}");
        }
    }
}
