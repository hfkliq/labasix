using System;

class Program
{
    static void Main()
    {
        // Ввод строки
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        // Переворачивание строки
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        // Вывод результата
        Console.WriteLine("Строка в обратном порядке: " + reversedString);
    }
}
