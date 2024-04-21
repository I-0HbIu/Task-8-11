using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace L8
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Л.8");
            TaskSelect();
        }
        
        public static void Task1()
        {
            Point First = new Point();
            Func1Select(First);
            EndCheck();
        }
        public static void Task2()
        {
            Payment aboba = new WorkerPayment();
            (string Name, string Salary, string Exper, string Worked,string Allowance,
            string Working,  string Allowsum,  string Taxsum, string Handed) = aboba;
            Console.WriteLine($"Сотрудник по имени {Name}, состоит на окладе в размере {Salary}, стаж работы - {Exper}, " +
                $"за месяц проработал {Worked} из {Working} дней. Получает " +
                $"надбавку в размере {Allowance} процентов. За этот месяц получил на руки {Handed}, (до вычета налогов и отчислений" +
                $" в размере {Taxsum} -  {Allowsum})");
            EndCheck();
        }
        public static void EndCheck()
        {
            Console.WriteLine("Для возврата в начальное меню нажмите 1. Для завершения работы программы нажмите ENTER.");
            ConsoleKeyInfo KeyEndCheck = Console.ReadKey();
            if (KeyEndCheck.Key == ConsoleKey.Enter)
            {
                End();
            }
            else
            {
                if (KeyEndCheck.KeyChar == '1')
                {
                    Console.Clear();
                    TaskSelect();
                }
                else
                {
                    Console.WriteLine("Неправильные вводные данные!");
                }
            }
        }
        public static void TaskSelect()
        {
            Console.Clear();
            Console.WriteLine("Нажмите 1 для перехода к заданию 1 или 2 для перехода к заданию 2:");
            ConsoleKeyInfo TaskCheck = Console.ReadKey();
            if (TaskCheck.KeyChar == '1')
            {
                Console.Clear();
                Task1();
            }
            else if (TaskCheck.KeyChar == '2')
            {
                Console.Clear();
                Task2();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Неправильные вводные данные!");
                TaskSelect();
            }
        }
        public static void Func1Select(Point Check)
        {
            metka:
            Console.WriteLine("\nНажмите 1 для перемещения точки, 2 для проверки расстояния до начала координат, 3 для проверки расстояния до другой точки или 4 для просмотра координат. Нажмите любую другую кнопку для выхода.");
            ConsoleKeyInfo FuncSelect = Console.ReadKey();
            if (FuncSelect.KeyChar == '1')
            {
                Check.move();
                goto metka;
            }
            else if (FuncSelect.KeyChar == '2')
            {
                
                Console.WriteLine("\nРасстояние до 0: " + Check.ToZero(Check.x, Check.y));
                goto metka;
            }
            else if (FuncSelect.KeyChar == '3')
            {
                Point Another = new Point();
                Console.WriteLine("\nСравнение с другой точкой");
                Console.WriteLine("\nРасстояние до указанной точки: " + Check.ToOtherPoint(Check.x, Check.y, Another.x, Another.y));
                goto metka;
            }
            else if (FuncSelect.KeyChar == '4')
            {
                (double x, double y) = Check;
                Console.WriteLine($"\nКоордината по Х: {x} , координата по Y: {y}");
                goto metka;
            }
            else
            {
                
            }
        }
        public static void End()
        {
            Console.WriteLine("Нажмите любую клавишу для возврата на начальный экран или ENTER для подтверждения выхода");
            ConsoleKeyInfo end = Console.ReadKey();
            if (end.Key != ConsoleKey.Enter)
                TaskSelect();
        }
        
    }
    class Point
    {
        double[] buf = new double[2]; 
        public double x;
        public double y;
        public void move()
        {
            for (int i = 0; i < 2; i++) 
            {
                while (true)
                {
                    try
                    {
                        if (i == 0)
                        {
                            Console.WriteLine("\nВведите смещение по Х");
                        }
                        else
                        {
                            Console.WriteLine("Введите смещение по Y");
                        }
                        buf[i] = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Вы ввели не число.");
                    }
                }
            }
            x = x + buf[0];
            y = y + buf[1];
            Console.WriteLine("\nТочка перемещена.\n");
        }
        public double ToZero(double x,double y)
        {
            double Len = Math.Sqrt(x*x + y*y);
            return Len;
        }
        public double ToOtherPoint(double x,double y,double x1,double y1) 
        {
            double Len = Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2));
            return Len;
        }
        public Point()
        {
            double[] buff = new double[2];
            for (int i = 0; i < 2; i++)
            {

                while (true)
                {
                    try
                    {
                        if (i == 0)
                        {
                            Console.WriteLine("Введите координату по Х");
                        }
                        else
                        {
                            Console.WriteLine("Введите координату по Y");
                        }
                        buff[i] = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Вы ввели не число.");
                    }
                }
            }
            this.x = buff[0];
            this.y = buff[1];

        }
        ~Point()
        {

        }
        public void Deconstruct(out double xex, out double yex)
        {
            xex = x; yex = y;
        }
    }
    class WorkerPayment : Payment
    {
        
    }

    abstract class Payment
    {

        public string name;
        public double salary;
        public int year;
        public double allowance;
        public int exper;
        public int worked;
        public int working;
        public double allowsum;
        public double taxsum;
        public double handed;
        public double hold;

        public void Deconstruct(out string Name, out string Salary, out string Exper, out string Worked, out string Allowance, 
            out string Working, out string Allowsum, out string Taxsum, out string Handed)
        {
            Name = name; Salary = salary.ToString(); 
            Exper = exper.ToString(); Worked = worked.ToString(); 
            Working = working.ToString(); Allowance = allowance.ToString(); 
            Taxsum = taxsum.ToString(); Allowsum = allowsum.ToString();  Handed = handed.ToString();
        }
        public int exp(int year)
        {
            return 2024 - year;
        }
        public double al(int worked, double salary, double allowance)
        {
            return worked*salary + worked * salary * (allowance/100);
        }
        public double holded(double tax, double pentax, int worked, double salary, double allowance)
        {
            return al(worked, salary, (allowance / 100)) * (tax + pentax);
        }
        public double toHand(double tax, double pentax, int worked, double salary, double allowance)
        {
            return al(worked, salary, (allowance / 100)) - holded(tax, pentax, worked, salary, allowance);
        }
        public Payment()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Укажите ФИО сотрудника");
                    name = Console.ReadLine();
                    Console.WriteLine("Укажите оклад");
                    salary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Укажите год найма сотрудника");
                    year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Укажите размер надбавки");
                    allowance = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Укажите количество рабочих дней сотрудника по факту");
                    worked = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Укажите количество рабочих дней сотрудника по плану");
                    working = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода.");
                }
            }
            
            exper = exp(year);
            allowsum = al(worked, salary, allowance);
            taxsum = allowsum * Consts.tax + allowsum * Consts.pentax;
            handed = allowsum - taxsum;
        }
        ~Payment()
        {

        }

    }
    interface Consts
    {
        const double tax = 0.13;
        const double pentax = 0.01;
    }
}