using System;

class Program
{
    static void Main()
    {
        // Ввод строки
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        // Разделение строки на слова вручную
        string[] words = SplitWords(input);

        // Нахождение длины самого короткого слова
        int minLength = int.MaxValue;
        foreach (string word in words)
        {
            if (word.Length < minLength)
            {
                minLength = word.Length;
            }
        }

        // Вывод результата
        Console.WriteLine("Длина самого короткого слова: " + minLength);
    }

    static string[] SplitWords(string input)
    {
        // Убираем лишние пробелы
        string trimmedInput = input.Trim();

        // Массив для хранения слов
        string[] words = new string[trimmedInput.Length];
        int wordCount = 0;
        string currentWord = "";

        foreach (char ch in trimmedInput)
        {
            if (char.IsWhiteSpace(ch))
            {
                if (currentWord.Length > 0)
                {
                    words[wordCount++] = currentWord;
                    currentWord = "";
                }
            }
            else
            {
                currentWord += ch;
            }
        }

        // Добавляем последнее слово, если оно есть
        if (currentWord.Length > 0)
        {
            words[wordCount++] = currentWord;
        }

        // Обрезаем массив до количества слов
        Array.Resize(ref words, wordCount);
        return words;
    }
}
