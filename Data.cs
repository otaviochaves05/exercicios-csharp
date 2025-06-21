// using System;
// using System.Security.Cryptography.X509Certificates;

// namespace exercicios_string
// {
//     struct DateInfo
//     {
//         public string Dia;
//         public string Mes;
//         public string Ano;
//     }

//     class Date
//     {
//         public static void Main(string[] args)
//         {
//             string[] dateParts = SplitDate("27/05/2021");
//             PrintDateInfo(dateParts);
//         }

//         public static string[] SplitDate(string date)
//         {
//             return date.Split("/");
//         }

//         public static void PrintDateInfo(string[] dateParts)
//         {
//             DateInfo info;

//             Console.WriteLine("Dia: " + (info.Dia = dateParts[0]));
//             Console.WriteLine("Mes: " + (info.Mes = dateParts[1]));
//             Console.WriteLine("Ano: " + (info.Ano = dateParts[2]));
//         }

//     }
// }