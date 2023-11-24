using System;
using System.IO;
using System.Collections.Generic;

class Program 
{
  public static void Main (string[] args) 
  {
    string numsTask2 = "numsTask2.txt";
    string word = "";
    List<string> words = new List<string>();
    try
    {
      do
      {
           Console.Write("Введите слово (для прекращения введите пустую строку): ");
           word = Console.ReadLine();
           if (word != "")
           {
               words.Add(word);
           }
      } while (word != "");
     
      using (StreamWriter writer = new StreamWriter(numsTask2))
      {
        foreach(string w in words)
        {
           File.AppendAllText(numsTask2, w + Environment.NewLine);
        }
      }

      string stringWords = "";
      using (StreamReader reader = new StreamReader(numsTask2))
      {
        string[] lines = File.ReadAllLines(numsTask2);
        stringWords = string.Join(" ", lines);
      }
      Console.WriteLine("Итоговая строка: ");
      Console.WriteLine(stringWords);
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
      File.Delete(numsTask2);
    }
  }
}