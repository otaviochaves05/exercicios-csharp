using System;


namespace exercicios_string
{
    class StrAnagram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("rato", "awegto"));
        }

        public static bool IsAnagram(string t, string s)
        {
            char[] str1 = t.ToCharArray();
            char[] str2 = s.ToCharArray();

            Array.Sort(str1);
            Array.Sort(str2);

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }
            return true;
        }

    }

}