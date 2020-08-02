using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-----------------------" +
                         "\nВыберите режим:\n" +
                         "1. Наблюдение\n" +
                         "2. Откат по дате\n" +
                         "-----------------------\n");
            string caseSwitch = Console.ReadLine();

            switch (caseSwitch)
            {
                case "1":
                    int num = 0;
                    TimerCallback tm = new TimerCallback(Observation_Mode.SaveCopy);
                    Timer timer = new Timer(tm, num, 0, 60000);

                    Console.ReadLine();
                    break;

                case "2":
                    RollingBack_Mode.RollingBack();
                    break;

            }
        }
    }
}

       