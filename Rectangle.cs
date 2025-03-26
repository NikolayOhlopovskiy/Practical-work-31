using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Rectangle : Figure
    {
        private double side1;
        private double side2;
        public Rectangle(double side1, double side2) : base("Прямоугольник")
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public double Side1
        {
            get { return side1; }
            set { side1 = value; }
        }
        public double Side2
        {
            get { return side2; }
            set { side2 = value; }
        }
        public override double Area()
        {
            return side1 * side2;
        }
        public override double Perimeter()
        {
            return 2 * (side1 + side2);
        }
        public override void Print()
        {
            // Сначала вызов метода базового класса
            base.Print();

            // Затем добавим вывод дополнительных полей
            Console.WriteLine($"Сторона 1: {Side1}");
            Console.WriteLine($"Сторона 2: {Side2}");
        }
    }
}
