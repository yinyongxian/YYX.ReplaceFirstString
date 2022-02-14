// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

String userName = "^(([a-z])+.)+[A-Z]([a-z])+$";
String password = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa!";
Regex testPassword = new Regex(userName);
Match match = testPassword.Match(password);
if (match.Success)
{
    Console.WriteLine("Do not include name in password.");
}
else
{
    Console.WriteLine("Good password.");
}

Console.ReadKey();