using System;

class Program
{
    static void Main()
    {
        // Ввод арифметического выражения
        Console.Write("Введите арифметическое выражение: ");
        string expression = Console.ReadLine();

        int result = 0;
        int currentNumber = 0;
        char currentOperation = '+'; // первая операция — сложение

        // Обработка строки
        foreach (char ch in expression)
        {
            if (char.IsDigit(ch))
            {
                currentNumber = currentNumber * 10 + (ch - '0');
            }
            else if (ch == '+' || ch == '-')
            {
                if (currentOperation == '+')
                {
                    result += currentNumber;
                }
                else if (currentOperation == '-')
                {
                    result -= currentNumber;
                }

                currentOperation = ch;
                currentNumber = 0;
            }
        }
        if (currentOperation == '+')
        {
            result += currentNumber;
        }
        else if (currentOperation == '-')
        {
            result -= currentNumber;
        }

        // Вывод результата
        Console.WriteLine("Результат выражения: " + result);
    }
}
