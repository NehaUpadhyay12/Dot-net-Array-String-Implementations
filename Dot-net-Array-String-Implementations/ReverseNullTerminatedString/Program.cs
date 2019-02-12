using System;
using System.Text;

namespace ReverseNullTerminatedString
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder("neha1\0");
            Console.WriteLine($"Actual String is {s.ToString()}");
            Reverse(s);
            
        }

        static void Reverse(StringBuilder str)
        {
            int end = str.Length - 1;
            if(end == 0)
            {
                Console.WriteLine("String is empty");
                return;
            }

            for (int i = 0; i <= (end - 1)/2; i++)
            {
                char temp = str[i];
                str[i] = str[end - i - 1];
                str[end - i - 1] = temp;
            }

            Console.WriteLine($"Reverse string is {str.ToString()}");
        }
    }
}
