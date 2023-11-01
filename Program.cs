using NPOI.SS.Formula.Functions;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;
using Rhino.Mocks.Constraints;
using System;

namespace ConsoleApp1
{
    class Program
    {
        
        public static void Shapka()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Введите 1 для решения уравнения y=kx");
            Console.WriteLine("Введите 2 для решения уравнения y=(k-n)x");
            Console.WriteLine("Введите 3 для решения уравнения y=(k-n)x");
            Console.WriteLine("Введите 4 для сравнеия чисел AB");
            Console.WriteLine("Введите 5 для сравнения выражения (A+B)^2 И (A-B)^2");
            Console.WriteLine("Введите 6 для решения факториала n!");
            Console.WriteLine("------------------------------------------------------");
        }

        public static void Kx()
        {
            int Y, K, X;
            Console.WriteLine("Решение уравнения y=kx");
            Console.WriteLine("Введите k");
            K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите х");
            X = Convert.ToInt32(Console.ReadLine());
            Y = K * X;
            Console.WriteLine($" Ответ: {Y}");
        }

        public static void D0_KN()
        {
            int Y, K, N, X;
            Console.WriteLine("Решение уравнения y=(k-n)x");
            Console.WriteLine("Введите k");
            K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите n");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите х");
            X = Convert.ToInt32(Console.ReadLine());
            Y = (K - N) * X;
            Console.WriteLine($" Ответ: {Y}");
        }
        public static void D0_KX3()
        {
            int Y, K, N, X;
            Console.WriteLine("Решение уравнения y=(k-n)x");
            Console.WriteLine("Введите k");
            K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите n");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите х");
            X = Convert.ToInt32(Console.ReadLine());
            Y = (K - N) * X;
            Console.WriteLine($" Ответ: {Y}");
        }
        public static void d0_AB()
        {
            int A, B;
            Console.WriteLine("Сравнение чисел AB");
            Console.WriteLine("Введите A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            B = Convert.ToInt32(Console.ReadLine());
            if (A > B)
                Console.WriteLine("A больше B");
            else if (A < B)
                Console.WriteLine("A меньше B");
            else Console.WriteLine("A равно B");
        }
        public static void do_AB()
        {
            int A, B;
            Console.WriteLine("Нахождение max, min");
            Console.WriteLine("Введите A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            B = Convert.ToInt32(Console.ReadLine());
            if (A > B)
            {
                Console.WriteLine("A максимальное");
                Console.WriteLine("B минимальное");
            }
            else if (A < B)
            { Console.WriteLine("B максимальное"); Console.WriteLine("A минимальное"); }
            else { Console.WriteLine("--------"); }
        }
        static void Main()
        {
            int Q;
            string Ress, Name;
            Console.WriteLine("Введите ваше имя");
            Name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте {Name}");
            do
            {


                Shapka();
                Q = Convert.ToInt32(Console.ReadLine());
                switch (Q)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        Console.Clear();
                        Kx();
                        break;
                    case 2:
                        Console.Clear();
                        D0_KN();
                        break;
                    case 3:
                        D0_KX3();
                        break;
                    case 4:
                        d0_AB();
                        break;
                    case 5:
                        do_AB();
                        break;


                }
                Console.WriteLine("\n Вы хотите продолжить Да/Нет[Y/N]:");
                    Ress = Console.ReadLine();


            } while (Ress is "Y" or "y");
        }
    }
}              
