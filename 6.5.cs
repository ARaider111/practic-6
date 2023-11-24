using System;

class Program
{
  public static void Main (string[] args)
  {
    int n = 0, m = 0;
    Console.WriteLine ("Введите длину строки:");
    m = int.Parse(Console.ReadLine());
    Console.WriteLine ("Введите длину столбца");
    n = int.Parse(Console.ReadLine());
    if (n == m)
    {
      Console.WriteLine ("Матрица не прямоугольная!");
      return;
    }

    Console.WriteLine("Изначальный массив: ");
    int[,] matrix = new int[n, m];
    Random rand = new Random();
    for (int i = 0; i < n; ++i)
    {
      for (int j = 0; j < m; ++j)
      {
        matrix[i, j]= rand.Next(0, 2);
        Console.Write(matrix[i, j] + " ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();

    int[,] newMatrix = new int[n, m + 1];
    for (int i = 0; i < n; ++i)
    {
      for (int j = 0; j < m; ++j)
      {
        newMatrix[i, j]= matrix[i, j];
      }
    }
    Console.WriteLine("Итогвоый массив: ");
    
    for (int i = 0; i < n; ++i)
    {
      int k = 0;
      for (int j = 0; j < m; ++j)
      {
        k += newMatrix[i, j];
      }
      
      if (k % 2 == 0)
      {
        newMatrix[i, m] = 0;
      }
      else
      {
        newMatrix[i, m] = 1;
      }
    }


    for (int i = 0; i < n; ++i)
    {
      for (int j = 0; j < m + 1; ++j)
      {
        Console.Write(newMatrix[i, j] + " ");
      }
      Console.WriteLine();
    }
  }
}