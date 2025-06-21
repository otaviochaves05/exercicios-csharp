// using System;
// using System.Security.Cryptography.X509Certificates;
// using System.Text.RegularExpressions;

// namespace exercicios_string
// {
//     class Email
//     {
//         struct EmailInfo
//         {
//             public string Usuario;
//             public string Dominio;
//             public bool Brasileiro;
//         }

//         public static void Main(String[] args)
//         {
//             string[] emailParts = SplitEmail("maria123@gmail.com.br");
//             bool isBrazilian = ValidateDomainEmail(emailParts[1]);
//             PrintEmailInfo(emailParts, isBrazilian);

//         }

//         public static string[] SplitEmail(string email)
//         {
//             return email.Split("@");
//         }

//         public static bool ValidateDomainEmail(string emailParts)
//         {
//             bool isBrazilian = Regex.IsMatch(emailParts, @"\.br$");
//             return isBrazilian;

//         }

//         public static void PrintEmailInfo(string[] emailParts, bool isBrazilian)
//         {
//             EmailInfo info;
//             info.Usuario = emailParts[0];
//             info.Dominio = emailParts[1];
//             info.Brasileiro = isBrazilian;

//             Console.WriteLine("Usuário: " + info.Usuario);
//             Console.WriteLine("Domínio: " + info.Dominio);
//             Console.WriteLine("Brasileiro: " + (info.Brasileiro ? "sim" : "nao"));
//         }
//     }
// }