using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForLesson2
{
    class The_Magnificent_Ten
    {
        static void Rectangle()
        {
            int a, b;

            do
            {
                Console.Write("A = ");
            }
            while (!int.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.Write("B = ");
            }
            while (!int.TryParse(Console.ReadLine(), out b));

            if (a > 0 && b > 0)
            {
                Console.WriteLine(a * b);
            }
            else
            {
                Console.WriteLine("Error");
            }

            Task1();
        }

        static void Triangle()
        {
            int n;

            do
            {
                Console.Write("N = ");
            }
            while (!int.TryParse(Console.ReadLine(), out n));

            string str = "";
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                str += "*";
                Console.WriteLine(str);
            }

            Task1();

        }

        static void Another_Triangle()
        {
            int n;

            do
            {
                Console.Write("N = ");
            }
            while (!int.TryParse(Console.ReadLine(), out n));
            Console.WriteLine();

            string star = "*";

            for (int i = 1; i < n + 1; i++)
            {
                string space = "";

                for (int j = 0; j < n - i; j++)
                {
                    space += " ";
                }
                Console.WriteLine(space + star);

                star += "**";
            }

            Task1();

        }

        static void Xmas_Tree()
        {
            int n;

            do
            {
                Console.Write("N = ");
            }
            while (!int.TryParse(Console.ReadLine(), out n));
            Console.WriteLine();

            for (int h = 0; h < n + 1; h++)
            {
                string star = "*";

                for (int i = 1; i < h + 1; i++)
                {
                    string space = "";

                    for (int j = 0; j < n - i; j++)
                    {
                        space += " ";
                    }
                    Console.WriteLine(space + star);

                    star += "**";
                }
            }
            Task1();
        }

        static void Sum_Of_Numbers()
        {
            int number = 1000;

            int sum3 = 0;
            int k = 0;
            while (k < number)
            {
                sum3 += k;
                k += 3;
            }

            int sum5 = 0;
            int l = 0;
            while (l < number)
            {
                sum5 += l;
                l += 5;
            }

            int sum15 = 0;
            int m = 0;
            while (m < number)
            {
                sum15 += m;
                m += 15;
            }

            Console.WriteLine("Sum of numbers = " + (sum3 + sum5 - sum15));

            Task1();
        }

        [Flags]
        enum FontsFlags
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4,
        }
        static void Font_Adjustment()
        {
            FontsFlags fonts = FontsFlags.None;
            string FontSwitch;
            bool work = true;

            while (work)
            {
                Console.WriteLine(
                    "Параметры надписи: " + fonts.ToString() + "\n" +
                    "Введите: \n" +
                    "        1: bold \n" +
                    "        2: italic \n" +
                    "        3: underline");

                FontSwitch = Console.ReadLine();

                switch (FontSwitch)
                {
                    case "1":
                        fonts ^= FontsFlags.Bold;
                        break;

                    case "2":
                        fonts ^= FontsFlags.Italic;
                        break;

                    case "3":
                        fonts ^= FontsFlags.Underline;
                        break;

                    case "*":
                        work = false;
                        Task1();
                        break;

                    default:
                        Console.WriteLine("Такого параметра нет");
                        break;

                }

            }

        }

        static int[] RandArray()
        {
            Random rnd = new Random();
            int n = 8;
            int[] numbers = new int[100];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            int[] randarr = new int[n];

            for (int i = 0; i < randarr.Length; i++)
            {
                randarr[i] = rnd.Next(numbers.Length);
            }

            return randarr;
        }


        static void Array_Processing(int[] arr)
        {
            Console.Write("Start array:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();

            int minindex = 0;
            int maxindex = 0;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int min = int.MaxValue;
                int max = 0;
                int c;

                for (int j = i; j < arr.Length - i; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        minindex = j;
                    }

                    if (arr[j] > max)
                    {
                        max = arr[j];
                        maxindex = j;
                    }
                }

                c = arr[i];

                if (i == maxindex)
                {
                    maxindex = minindex;
                }

                arr[i] = min;
                arr[minindex] = c;

                c = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = max;
                arr[maxindex] = c;

            }

            Console.Write("Sort array :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();

            Task1();
        }

        static void No_Positive()
        {
            Random rnd = new Random();
            int n = 2;

            int[,,] randarr = new int[n, n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        randarr[i, j, k] = rnd.Next(-50, 50);
                        Console.Write(randarr[i, j, k] + " ");
                    }

                }

            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (randarr[i, j, k] > 0)
                        {
                            randarr[i, j, k] = 0;
                            Console.Write(randarr[i, j, k] + " ");
                        }
                        else
                            Console.Write(randarr[i, j, k] + " ");

                    }

                }

            }
            Console.WriteLine();

            Task1();
        }

        static void NonNegative_Sum()
        {
            Random rnd = new Random();
            int n = 10;
            int sum = 0;
            int[] randarr = new int[n];

            for (int k = 0; k < n; k++)
            {
                randarr[k] = rnd.Next(-5, 5);
                Console.Write(randarr[k] + " ");
            }
            Console.WriteLine();

            for (int k = 0; k < n; k++)
            {
                if (randarr[k] > 0)
                {
                    sum += randarr[k];
                }
            }
            Console.WriteLine("Sum = " + sum);

            Task1();
        }

        static void Two_Dimensional()
        {
            Random rnd = new Random();
            int n = 3;
            int sum = 0;
            int[,] randarr = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    randarr[i, j] = rnd.Next(-50, 50);
                    Console.Write("{0}\t", randarr[i, j]);
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (((i + j) % 2) == 0)
                    {
                        Console.Write(randarr[i, j] + " ");
                        sum += randarr[i, j];
                    }
                }
            }
            Console.WriteLine("\nSum = " + sum);

            Task1();
        }

        public static void Task1()
        {
            
            bool work = true;

            while (work)
            {
                Console.WriteLine("-----------------------" +
                              "\nВведите номер задания THE MAGNIFICENT TEN\n" +
                               "Для возврата введите: *\n" +
                              "-----------------------");
                string caseSwitch = Console.ReadLine();

                switch (caseSwitch)
                {
                    case "1":
                        Console.WriteLine("1.1.1");
                        Rectangle();
                        break;

                    case "2":
                        Console.WriteLine("1.1.2");
                        Triangle();
                        break;

                    case "3":
                        Console.WriteLine("1.1.3");
                        Another_Triangle();
                        break;

                    case "4":
                        Console.WriteLine("1.1.4");
                        Xmas_Tree();
                        break;

                    case "5":
                        Console.WriteLine("1.1.5");
                        Sum_Of_Numbers();
                        break;

                    case "6":
                        Console.WriteLine("1.1.6   \n" +
                                          "///// Чтобы вернуться к выбору заданий введите : *\n");
                        Font_Adjustment();
                        break;

                    case "7":
                        Console.WriteLine("1.1.7");
                        Array_Processing(RandArray());
                        break;

                    case "8":
                        Console.WriteLine("1.1.8");
                        No_Positive();
                        break;

                    case "9":
                        Console.WriteLine("1.1.9");
                        NonNegative_Sum();
                        break;

                    case "10":
                        Console.WriteLine("1.1.10");
                        Two_Dimensional();
                        break;

                    case "*":
                        work = false;
                        Tasks.ListOfTasks();
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }

        }

    }
}
