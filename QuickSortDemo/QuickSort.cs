using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortDemo
{
    public class QuickSort
    {
        public void ExplainRules()
        {            
            Console.WriteLine("Hey there! Let's generate an array of integers. Tell me it's length and press ENTER!");
            int lenght = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine($"Ok, there will be an array of {lenght} random values between 0 and 10!");            
            Console.WriteLine("Here is the array!");
            var arr = GetArray(lenght);
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }            
        }

        private int[] GetArray(int input)
        {
            int[] arr = new int[input];
            var rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 11);
            }
            return arr;
        }
    }
}
