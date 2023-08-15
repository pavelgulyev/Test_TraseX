using System.Collections.Generic;

Console.WriteLine("Введите строку:");
string text = Console.ReadLine();

Console.WriteLine(text);
char[] obrtext = text.ToCharArray();
Array.Reverse(obrtext);
string finaltext = new string(obrtext);
if (text == finaltext)
{
    Console.WriteLine("Данная строка является палиндромом");
}
if (text != finaltext)
{
    Console.WriteLine("Данная строка не является палиндромом");
}
