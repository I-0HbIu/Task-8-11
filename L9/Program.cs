using System.Drawing;
using System.Formats.Asn1;
using System.Xml.Linq;

namespace L9
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            
        metka4:
            Figure[] Figures = new Figure[100];
            Console.WriteLine("Введите количество фигур");
            int n = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref Figures, n);
            Creation(Figures, n);
            metka5:
            Console.WriteLine("\nНажмите 1 для просмотра массива, 2 для очистки массива, 3 для создания нового массива или любую другую клавишу для выхода.");
            ConsoleKeyInfo ActSelect = Console.ReadKey();
            if (ActSelect.KeyChar == '1')
            {
                View(Figures);
                goto metka5;
            }
            else if (ActSelect.KeyChar == '2')
            {
                Array.Clear(Figures);
                Array.Resize(ref Figures, 0);
                goto metka5;
            }
            else if (ActSelect.KeyChar == '2')
            {
                Array.Clear(Figures);
                Array.Resize(ref Figures, 0);
                goto metka4;
            }
            else
            {
                Console.WriteLine("Работа завершена!"); 
            }
            
        }
        public static void View(Figure[] Figures)
        {
            if (Figures.Length == 0)
            {
                Console.WriteLine("Массив пуст");
            }
            else
            {
                for (int i = 0; i < Figures.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + Figures[i].GetInfo());
                }
            }
        }

        public static void Creation(Figure[] Figures, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Фигура {i+1}");
            metka1:
                Console.WriteLine("\nНажмите 1 для создания треугольника, 2 для создания четырёхугольника");
                ConsoleKeyInfo FigSelect = Console.ReadKey();
                if (FigSelect.KeyChar == '1')
                {
                metka2:
                    Console.WriteLine("\nНажмите 1 для создания прямоугольного треугольника, 2 для создания равнобедренного или 3 для создания равностороннего");
                    ConsoleKeyInfo TrSelect = Console.ReadKey();
                    if (TrSelect.KeyChar == '1')
                    {
                        Figures[i] = new Rectangular();
                    }
                    else if (TrSelect.KeyChar == '2')
                    {
                        Figures[i] = new Isosceless();
                    }
                    else if (TrSelect.KeyChar == '3')
                    {
                        Figures[i] = new Equilateral();
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода!");
                        goto metka2;
                    }
                }
                else if (FigSelect.KeyChar == '2')
                {
                metka3:
                    Console.WriteLine("\nНажмите 1 для создания квадрата");
                    ConsoleKeyInfo SqSelect = Console.ReadKey();
                    if (SqSelect.KeyChar == '1')
                    {
                        Figures[i] = new Square();
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода!");
                        goto metka3;
                    }
                }

                else
                {
                    Console.WriteLine("Ошибка ввода!");
                    goto metka1;
                }
            }
        }
    }
    abstract class Figure
    {
        public string name;
        public double area;
        public abstract string GetInfo();
    }
    abstract class Triangle:Figure
    {

        public double a;
        public double b;
        public double c;
 
        public double Area(double a, double b, double c)
        {
            return Math.Sqrt(((a + b + c) / 2) * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c));
        }
         


    }
    abstract class Quadrilateral:Figure
    {
        public double a;
        public double b;
        public double c;
        public double d;
        public double Area(double a, double b, double c, double d)
        {
            return a * b;
        }

    }
    class Rectangular: Triangle
    {
        public Rectangular()
        {
            ChReTr:
            name = "Прямоугольный треугольник";
            Console.WriteLine("\n"+name);
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите длину 1 катета");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите длину 2 катета");
                    b = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch 
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            c = Math.Sqrt(a*a+b*b);          
            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                Console.WriteLine("Такой треугольник невозможен");
                goto ChReTr;
            }
            area = Area(a, b, c);

        }
        public override string GetInfo()
        {
            return $"Название фигуры - {name}, стороны - {a}, {b}, {c}, площадь = {area}";
        }
        
        ~Rectangular()
        {
            Console.WriteLine($"{name} удалён");
        }

    }
    class Isosceless: Triangle
    {
        public Isosceless()
        {
        ChIsTr:
            name = "Равнобедренный треугольник";
            Console.WriteLine("\n" + name);
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите боковую сторону");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите основание");
                    b = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            c = a;
            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                Console.WriteLine("Такой треугольник невозможен");
                goto ChIsTr;
            }
            area = Area(a, b, c);
        }
        public override string GetInfo()
        {
            return $"Название фигуры - {name}, стороны - {a}, {b}, {c}, площадь = {area}";
        }
       
        ~Isosceless()
        {
            Console.WriteLine($"{name} удалён");
        }
    }
    class Equilateral: Triangle
    {
        public Equilateral()
        {
            name = "Равносторонний треугольник";
            Console.WriteLine("\n" + name);
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите сторону треугольника");
                    a = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            b=c=a;
            area = Area(a, b, c);
        }

        public override string GetInfo()
        {
            return $"Название фигуры - {name}, стороны - {a}, {b}, {c}, площадь = {area}";
        }
      
        ~Equilateral()
        {
            Console.WriteLine($"{name} удалён");
        }
    }
    class Square:Quadrilateral
    {
        public Square() 
        {
            name = "Квадрат";
            Console.WriteLine("\n" + name);
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите сторону квадрата");
                    a = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            b = c = d = a;
            area = Area(a, b, c, d);
        }
        public override string GetInfo()
        {
            return $"Название фигуры - {name}, стороны - {a}, {b}, {c}, {d}, площадь = {area}";
        }
        
        ~Square()
        {
            Console.WriteLine($"{name} удалён");
        }
    }
}