using System;
using System.IO;

class Program 
{
  public static void Main (string[] args) 
  {
    string numsTask1 = "numsTask1.txt";

    string words= "";
    try
    {
      Console.WriteLine("Введите слова (через пробел): ");
      words = Console.ReadLine();
      using (StreamWriter writer = new StreamWriter(numsTask1))
      {
        writer.WriteLine(words);
      }

      using (StreamReader reader = new StreamReader(numsTask1))
      {
        words = reader.ReadLine();
      }

      Console.WriteLine("Слова с нечетной длдинной:");
      string[] masWords = words.Split(" ");
      foreach (string word in masWords)
      {
        int lengthWord = word.Length;
        if (lengthWord % 2 == 1)
        {
          Console.WriteLine($"{word} - {lengthWord}");
        }
      }
    }

    catch (FileNotFoundException)
    {
        Console.WriteLine("Файл не найден");
    }
    catch (IOException)
    {
        Console.WriteLine("Ошибка чтения файла или записи в файл");
    }

    finally 
    {
      Console.WriteLine("Нажмите любую клавишу для завершения программы");
      Console.ReadKey();
      File.Delete(numsTask1);
    }
  }
}