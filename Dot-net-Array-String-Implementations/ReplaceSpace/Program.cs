using System;

namespace ReplaceSpace
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReplaceSpace("Mr  Smith    ", 9);
            ReplaceSpaceBackwards("Mr  Smith    ".ToCharArray(), 9);
        }

        public static void ReplaceSpace(string str, int length)
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (str[i] == ' ')
                    count++;
            }

            int arrLength = length + (count * 2);
            char[] arr = new char[arrLength];
            int k = 0;
            for (int i=0; i<length;i++)
            {
                if (str[i] == ' ')
                {
                    arr[k] = '%';
                    arr[++k] = '2';
                    arr[++k] = '0';
                    k++;
                }
                else
                {
                    arr[k] = str[i];
                    k++;
                }
            }
            Console.WriteLine(new string(arr));
        }

        public static void ReplaceSpaceBackwards(char[] str, int length)
        {
            int spaceCount = 0, i = 0, newLength=0;
            for (i = 0; i < length; i++)
            {
                if (str[i] == ' ')
                    spaceCount++;
            }

            newLength = length + (spaceCount * 2);

            for (i = length-1; i > 0; i--)
            {
                if(str[i]==' ')
                {
                    str[newLength - 1] = '0';
                    str[newLength - 2] = '2';
                    str[newLength - 3] = '%';
                    newLength = newLength - 3;
                }
                else
                {
                    str[newLength - 1] = str[i];
                    newLength--;
               }
            }
            Console.WriteLine(new String(str));
        }
    }
}
