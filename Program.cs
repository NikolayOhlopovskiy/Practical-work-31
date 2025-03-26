using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static List<Figure> figures = new List<Figure>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n1. Добавить фигуру");
                Console.WriteLine("2. Показать все фигуры");
                Console.WriteLine("3. Удалить фигуру");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddFigure(); break;
                    case "2": ShowFigures(); break;
                    case "3": DeleteFigure(); break;
                    case "0": return;
                    default: Console.WriteLine("Неверный ввод"); break;
                }
            }
        }

        static void AddFigure()
        {
            Console.WriteLine("Тип фигуры: 1-Квадрат, 2-Круг, 3-Треугольник, 4-Прямоугольник");
            string type = Console.ReadLine();

            try
            {
                switch (type)
                {
                    case "1":
                        Console.Write("Сторона: ");
                        double s = double.Parse(Console.ReadLine());
                        figures.Add(new Square(s));
                        break;
                    case "2":
                        Console.Write("Радиус: ");
                        double r = double.Parse(Console.ReadLine());
                        figures.Add(new Circle(r));
                        break;
                    case "3":
                        Console.Write("Сторона: ");
                        double t = double.Parse(Console.ReadLine());
                        figures.Add(new Triangle(t));
                        break;
                    case "4":
                        Console.Write("Сторона 1: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Сторона 2: ");
                        double b = double.Parse(Console.ReadLine());
                        figures.Add(new Rectangle(a, b));
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }

        static void ShowFigures()
        {
            if (figures.Count == 0)
            {
                Console.WriteLine("Фигуры не добавлены.");
                return;
            }

            for (int i = 0; i < figures.Count; i++)
            {
                Console.WriteLine($"\n[{i + 1}]");
                figures[i].Print();
            }
        }

        static void DeleteFigure()
        {
            ShowFigures();
            Console.Write("Введите номер фигуры для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= figures.Count)
            {
                figures.RemoveAt(index - 1);
                Console.WriteLine("Удалено.");
            }
            else
            {
                Console.WriteLine("Неверный номер.");
            }
        }
    }
}
