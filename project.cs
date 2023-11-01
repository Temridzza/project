using System;
using function;

namespace artem
{
    class Program
    {
        static void Main()
        {
            int Q;
            string Ress, Name;
            Console.WriteLine("Введите ваше имя");
            Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Здравствуйте {Name}");
            do
            {


                Function.Menu();
                Q = Convert.ToInt32(Console.ReadLine());
                switch (Q)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        Console.Clear();
                        Function.Kx();
                        break;
                    case 2:
                        Console.Clear();
                        Function.D0_KN();
                        break;
                    case 3:
                        Console.Clear();
                        Function.D0_KX3();
                        break;
                    case 4:
                        Console.Clear();
                        Function.D0_AB();
                        break;
                    case 5:
                        Console.Clear();
                        Function.Do_AB();
                        break;


                }
                Console.Clear();
                Console.WriteLine("\n Вы хотите продолжить Да/Нет[Y/N]:");
                Ress = Console.ReadLine();


            } while (Ress is "Y" or "y");
        }
    }
}
