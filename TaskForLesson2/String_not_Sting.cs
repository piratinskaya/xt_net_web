using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForLesson2 
{
    class String_not_Sting
    {
        static string[] Separator(string text)
        {
            char[] separators = new char[] { ' ', '.', ',', ':', ';', '!', '?', '»', '«' };
            string[] wordsArray = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return wordsArray;
        }

        static void Averages()
        {
            string text = Console.ReadLine();
            //string text = "Викентий хорошо отметил день рождения: покушал пиццу, " +
                        //  "посмотрел кино, пообщался со студентами в чате";

            string[] wordsArray = Separator(text);
            double allWordLength = 0.0;

            foreach (var item in wordsArray)
            {
                allWordLength += item.Length;
            }

            double average_sum = allWordLength / wordsArray.Length;
            Console.WriteLine(Math.Round(average_sum)); //используется метод округление до целого числа double 
                                                        //можно так же просто выбрать тип int и ничего не округлять 
                                                        //самостоятельно
        }

        static void Doubler()
        {
            Console.WriteLine("Введите первую строку");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            string str2 = Console.ReadLine();
            string final = "";

            foreach (char ch in str1)
                if (!str2.Contains(ch))
                    final += ch;
                else
                {
                    final += ch;
                    final += ch;
                }
            Console.WriteLine(final);
            Console.ReadLine();

        }

        static void Lowercase()
        {
            Console.WriteLine();
            string str  = Console.ReadLine();
            //string str = "Антон хорошо начал утро: послушал Стинга, выпил кофе и посмотрел Звёздные Войны";
            string[] words = Separator(str);
            int counter = words.Count(w => !char.IsUpper(w[0])); ;

            //только для русского алфавита
            //foreach (string item in words)
            //{
            //    char dd = Convert.ToChar(item[0]);
            //    byte ff = Encoding.GetEncoding(1251).GetBytes(new char[] { dd })[0];
            //    if (ff >= 224 && ff <= 255)
            //        counter++;                              
            //}


            Console.WriteLine(counter);
            Console.ReadLine();
        }

        static void Validator()
        {
            string text = "я плохо учил русский язык. забываю начинать предложения " +
                          "с заглавной. хорошо, что можно написать программу!";
            char[] separators = new char[] { '.', '!', '?', ' ' };
            string[] wordsArray = text.Split(separators, StringSplitOptions.None);
            string d = "";
            text.Replace(text.Substring(0, 1), text.Substring(0, 1).ToUpper());
            //for (int i = 0; i < wordsArray.Length; i++)
            //{
            //    wordsArray[0].Replace(wordsArray[0].Substring(0, 1) , wordsArray[0].Substring(0,1).ToUpper());
            //    Console.WriteLine(wordsArray[i]);
            //}
               // item.Substring(0,1).ToUpper();
            
             
            Console.WriteLine(text);
            Console.ReadLine();
        }

        public static void Task2()
        {

            Console.WriteLine("\n-----------------------" +
                              "\nвведите номер задания:\n" +
                              "-----------------------\n");

            string caseSwitch = Console.ReadLine();

            switch (caseSwitch)
            {
                case "1":
                    Console.WriteLine("1.2.1");
                    Averages();
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("1.2.2");
                    Doubler();
                    break;

                case "3":
                    Console.WriteLine("1.2.3");
                    Lowercase();
                    break;

                case "4":
                    Console.WriteLine("1.2.4");
                    Validator();
                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }

        }
    
    }
}
