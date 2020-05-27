using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForLesson2
{
    class Tasks
    {
        public static void ListOfTasks()
        {
            Console.WriteLine("\n-----------------------" +
                          "\nВыберите задание:\n" +
                          "1. THE MAGNIFICENT TEN\n" +
                          "2. STRING, NOT STING\n" +
                          "-----------------------\n");
            string caseSwitch = Console.ReadLine();

            switch (caseSwitch)
            {
                case "1":
                    Console.WriteLine("THE MAGNIFICENT TEN");
                    The_Magnificent_Ten.Task1();
                    break;

                case "2":
                    Console.WriteLine("STRING, NOT STING");
                    String_not_Sting.Task2();
                    break;

            }
        }
    }
}
