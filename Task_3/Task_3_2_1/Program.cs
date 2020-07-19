using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[] { 13, 5, 77, 6, 8, 10, 1, 0 };
            
            DynamicArray<int> arr = new DynamicArray<int>(mass);
          
            Console.WriteLine(arr.Capacity +"\n" + arr.Length);
            
            foreach (var item in arr)
            {
                Console.Write(item);
                Console.Write(" ");
            }

            Console.WriteLine();

            int add = 555;
            arr.Add(add);

            Console.WriteLine(arr.Capacity + "\n" + arr.Length);

            arr.Capacity = 15;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write( arr[i] );
                Console.Write(" ");
            }
        }
    }
}
