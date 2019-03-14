using System;

namespace Substring
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str1 = "waterbottle";
            string str2 = "erbottlewat";
            bool result;
            if (str1.Length < str2.Length)
                result = isSubString(str1, str2, false);
            else if (str1.Length > str2.Length)
                result = isSubString(str2, str1, false);
            else
                result = isSubString(str1, str2, true);

            if (result)
                Console.WriteLine("This is substring");
            else
                Console.WriteLine("Not a substring");
        }

        static bool isSubString(string str1, string str2, bool isLengthEqual)
        {
            int i = 0, j = 0;
            bool isSubStr = false;

            if (!isLengthEqual)
            {
                while (i < str1.Length)
                {
                    if (str1[i] == str2[j])
                    {
                        i++;
                        j++;
                        isSubStr = true;

                    }
                    else
                    {
                        j++;
                        i = 0;
                        isSubStr = false;
                        if (j == str2.Length)
                            break;
                    }
                }
            }
            else
            {
                while (i < str1.Length)
                {
                    if (str1[i] == str2[j])
                    {
                        i++;
                        if (j == str2.Length-1)
                        {
                            if (isSubStr)
                                j = 0;
                            else
                            {
                                isSubStr = false;
                                break;
                            }
                        }
                        else
                        {
                            j++;
                            isSubStr = true;
                        }
                    }
                    else
                    {
                        if (isSubStr)
                        {
                            isSubStr = false;
                            break;
                        }
                        else
                        {
                            j++;
                            i = 0;
                            isSubStr = false;
                        }
                    }
                }
            }

            return isSubStr;
        }

    }
}