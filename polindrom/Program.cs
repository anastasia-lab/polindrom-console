using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Здравствуй, мой дорогой друг.\n\n");
            Console.Write("Выбери, пожалуйста, что ты хочешь узнать:\n1 - является ли Ваша запись полиндромом; 2 - количество символов в Вашей запись");
            Console.Write("\nВаш выбор: ");
            var input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.Write("\nПожалуйста, введите Вашу запись. \n");
                var userString = Console.ReadLine();

                char[] arrayUserString = userString.ToArray();

                for (int i = 0; i < arrayUserString.Length / 2; i++)
                {
                    if (arrayUserString[i] == arrayUserString[arrayUserString.Length - i - 1])
                        Console.WriteLine("Ваша запись является полиндромом.");

                    if (arrayUserString[i] != arrayUserString[arrayUserString.Length - i - 1])
                        Console.WriteLine("Ваша запись не является полиндромом.");
                }
            }

            if (input == 2)
            {
                Console.Write("Пожалуйста, введите Вашу запись. \n");
                string userString = Console.ReadLine();

                string[] array;
                array = userString.Split(' ');
                Console.Write("Количество слов в Вашей записи: ");
                Console.WriteLine(array.Length);
            }

            Console.ReadKey();

        }
    }
}
