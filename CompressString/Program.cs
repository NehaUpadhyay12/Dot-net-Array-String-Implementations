using System;

namespace CompressString
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CompressSring("abbcdseee");
        }

        public static void CompressSring(string str)
        {
            int j = 0;
            char[] newStr = new char[str.Length];
            newStr[0] = str[0];
            int count = 1;
            bool repeated = false;

            for (int i = 1; i < str.Length; i++)
            {
                if(newStr[j] == str[i])
                {
                    count++;
                    newStr[j + 1] = Convert.ToChar(count.ToString());
                    repeated = true;
                }
                else
                {
                    if (repeated)
                        j = j + 2;
                    else
                        j++;
                    repeated = false;
                    count = 1;
                    newStr[j] = str[i];
                }
            }

            Console.WriteLine(newStr);
            Console.WriteLine(newStr.Length);
        }
    }
}
