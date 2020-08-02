using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Observation_Mode
    {
        public static void SaveCopy(object obj)
        {
            DateTime thisDay = DateTime.Now;

            string sTime = thisDay.ToString("hh_mm");
            string sDate = thisDay.ToString("dd_MM_yyyy");
            string folderDate = sDate + "_" + sTime;
            string path = @"C:\SomeDir\actual";
            string path2 = @"C:\SomeDir\Copy";
            string subpath = folderDate;

            Console.WriteLine(folderDate);

            DirectoryInfo dr = new DirectoryInfo(path);
            DirectoryInfo dirInfo = new DirectoryInfo(path2);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            DirectoryInfo newCopy = dirInfo.CreateSubdirectory(subpath);

            foreach (FileInfo fi in dr.GetFiles("*.txt"))
            {

                fi.CopyTo(newCopy.FullName +"\\" +  fi.Name, true);
            }

          
        }
    }
}
