using System;

class Program
{
    static void Main()
    {
        // Ввод данных
        Console.Write("Введите строку S: ");
        string S = Console.ReadLine();

        Console.Write("Введите символ C: ");
        char C = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Введите строку S0: ");
        string S0 = Console.ReadLine();

        // Вставка S0 после каждого вхождения C
        string result = "";
        foreach (char ch in S)
        {
            result += ch; // Добавляем текущий символ
            if (ch == C)
            {
                result += S0; // Вставляем строку S0 после символа C
            }
        }

        // Вывод результата
        Console.WriteLine("Результат: " + result);
    }
}
