using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

Console.Write("Введите образец: ");
string obrazec = Console.ReadLine();

int count = 0;

Console.WriteLine("Вводите строки (пустая строка - конец ввода): ");
string str = Console.ReadLine();
while (str != "") {
    count += Regex.Matches(str, obrazec).Count;
    str = Console.ReadLine();
} 

Console.WriteLine($"Всего вхождений: {count}");
