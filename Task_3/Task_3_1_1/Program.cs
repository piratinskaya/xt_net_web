using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1_1
{
    class Program
    {
        static void Main()
        {
            int n;

            do
            {
                Console.WriteLine("Введите N");
            }
            while (!int.TryParse(Console.ReadLine(), out n));

            Console.WriteLine("Сгенерирован круг людей. Начинаем вычеркивать каждого второго.");

            var personList = GenerateList(n);
            var p = personList;
            int round = 0;

            while (p != p.NextPerson)
            {
                if (personList == p.NextPerson)
                {
                    personList = p.NextPerson.NextPerson;
                }

                p = p.NextPerson = p.NextPerson.NextPerson;
                round++;
                Console.Write("Раунд " + round);
                PrintList(personList);
            }
            Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");
        }

        // Вывод списка на консоль
        private static void PrintList(Person personList)
        {
            var p = personList;
            int count = 0;

            do
            {
                count++;
                p = p.NextPerson;
            } while (p != personList);

            Console.WriteLine(". Вычеркнут человек. Людей осталось: " + count);

        }

        // Генерация списка
        private static Person GenerateList(int n)
        {
            var currentPerson = new Person(n);
            var lastPerson = currentPerson;

            for (int i = n - 1; i > 0; i--)
            {
                currentPerson = new Person(i) { NextPerson = currentPerson };
            }

            lastPerson.NextPerson = currentPerson;
            return currentPerson;
        }
    }

}
