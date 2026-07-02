using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstProject
{
    class Program
    {
        private const string FilePath = "people.txt";
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
                switch(choice)
                {
                    case "1":
                        //1. CREATE


                        Console.Write("Въведете име: ");
                        string name = Console.ReadLine();

                        Console.Write("Въведете възраст:");
                        int age = int.Parse(Console.ReadLine());

                        Console.Write("Въведете заплата: ");
                        double salary = double.Parse(Console.ReadLine());

                        Person newPerson = new Person(name, age, salary);
                        people.Add(newPerson);

                        SavePeopleToFile(people);
                        Console.WriteLine("Успешно добавен нов запис!");
                        Console.WriteLine();
                        break;

                    case "2":
                        //2.READ

                        Console.WriteLine("---Списък с хора---");
                        if(people.Count == 0)
                        {
                            Console.WriteLine("Списъка с хора е празен(няма записи във файла).");
                        }
                        else
                        {
                            foreach (Person p in people)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;

                    





                }
            }
        }
        static List<Person> LoadPeopleFromFile()
        {
            List<Person> people = new List<Person>();
                    if (!File.Exists(FilePath))
            {
                return people;
            }
            string[] lines = File.ReadAllLines(FilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');

                Person person = new Person(
                    parts[0],
                    int.Parse(parts[1]),
                    double.Parse(parts[2]));
                people.Add(person);

            }
            return people;

             
        }
        static void SavePeopleToFile(List<Person> people)
        {
            List<string> rows = new List<string>();
            foreach (Person p in people)
            {
                rows.Add(p.ToFileRow());

            }
            File.WriteAllLines(FilePath, rows);
        }
    }
}
