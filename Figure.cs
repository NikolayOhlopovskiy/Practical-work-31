using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp6
{
    public abstract class Figure
    {
        private string name;
        public Figure(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public abstract double Area();
        public abstract double Perimeter();
    
      public virtual void Print()
      {
        Console.WriteLine($"Фигура: {Name}");
        Console.WriteLine($"Площадь: {Area():F2}");
        Console.WriteLine($"Периметр: {Perimeter():F2}");
      }
    }
}
