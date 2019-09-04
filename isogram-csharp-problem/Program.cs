using System;

namespace isogram_csharp_problem
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
        }
        public static bool isogram(string text)
        {
            int len = text.Length;

            char[] arr = text.ToCharArray();

            Array.Sort(arr);
            for (int i = 0; i < len - 1; i++)
            {
                if (arr[i] != ' ' && arr[i] != '-')
                {
                    if (arr[i] == arr[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }
            return true;
        }
    }
}
