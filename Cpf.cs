// using System;
// using System.Text.RegularExpressions;

// namespace exercicios_string
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine(RemoveNonDigits("156..efjqenqobje181.716-35"));
//             Console.WriteLine(RemoveNonDigitsWithRegex("156..efjqenqobje181.716-35"));
//         }

//         public static string RemoveNonDigits(string str)
//         {
//             string newStr = "";
//             for (int i = 0; i < str.Length; i++)
//             {
//                 if (str[i] >= '0' && str[i] <= '9')
//                 {
//                     newStr += str[i];
//                 }
//             }
//             return newStr;
//         }

//         public static string RemoveNonDigitsWithRegex(string str)
//         {
//             string regex = @"\D";
//             return Regex.Replace(str, regex, "");
//         }
//     }
// }
        
        



