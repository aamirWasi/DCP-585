using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            //string value = "Welcome To Csharpstar";
            // Use ToCharArray to convert string to array.
            //char[] array = str1.ToCharArray();
            int count = 0;
            // Loop through array.
            for (int i = 0; i < str1.Length; i++)
            {
                // Get character from array.
                char ch = str1[i];
                if (ch==str1[i])
                {
                    count++;
                    Console.WriteLine(ch);
                }
            }
        }
    }
}
