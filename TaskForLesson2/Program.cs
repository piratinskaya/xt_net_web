using System;



namespace TaskForLesson2
{
    class Program 
    {
        static void Main(string[] args)
        {
            string caseSwitch = Console.ReadLine();

            switch (caseSwitch)
            {
                case "1":
                    Console.WriteLine("1");
                    The_Magnificent_Ten.Task1();
                    break;

                case "2":
                    Console.WriteLine("2");
                    String_not_Sting.Task2();
                    break;

            }
        }
    }
}
