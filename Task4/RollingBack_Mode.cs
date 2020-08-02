using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class RollingBack_Mode
    {
        public static void RollingBack()
        {
            Console.WriteLine("Введите дату отката в формате dd_MM_yyyy_hh_mm," +
                            "\n....................например  31_07_2020_05_29");
            string datepath = Console.ReadLine();           
            string path = @"C:\SomeDir\actual";
            string path3 = @"C:\SomeDir\Copy" + "\\" + datepath;

            DirectoryInfo dr = new DirectoryInfo(path);
            DirectoryInfo newCopy = new DirectoryInfo(path3); 

            foreach (FileInfo fi in newCopy.GetFiles("*.txt"))
            {

                fi.CopyTo(dr.FullName + "\\" + fi.Name, true);
            }


        }
    }
}
