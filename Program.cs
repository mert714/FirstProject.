using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = LoadPeopleFromFile();
            bool running = true;
            while (running)
            {
                Console.WriteLine("--Избери операция--");
                Console.WriteLine("1.CREATE(Добавяне на човек)");
                Console.WriteLine("2.READ(Показване на всички)");
                Console.WriteLine("3.UPDATE(Промяна на заплата)");
                Console.WriteLine("4.DELETE(Изтриване по име)");
                Console.WriteLine("5.Изход");
                Console.Write("Избор:");

                string choice = Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
