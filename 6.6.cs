using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int k = 0;
    Console.WriteLine ("Введите количество чисел в массиве: ");
    k = int.Parse(Console.ReadLine());

    Console.WriteLine("Изначальный массив: ");
    double[] numbers = new double[k];
    Random rand = new Random();
    int positive = 0, negative = 0;
    for (int i = 0; i < numbers.Length; ++i)
    {
      numbers[i] = rand.NextDouble() * 20 - 10;
      if (numbers[i] > 0)
      {
        ++positive;
      }
      else
      {
        ++negative;
      }
      Console.Write("{0:f2} ", numbers[i]);
    }
    Console.WriteLine();
    
    double[] positiveNumbers = new double[positive];
    double[] negativeNumbers = new double[negative];
    int p = 0, n = 0;
    for (int i = 0; i < numbers.Length; ++i)
    {
      if (numbers[i] > 0)
      {
        positiveNumbers[p] = numbers[i];
        ++p;
      }
      else
      {
        negativeNumbers[n] = numbers[i];
        ++n;
      }
    }

    Console.WriteLine("Массив с положительными числами: ");
    for (int i = 0; i < positiveNumbers.Length; ++i)
    {
      Console.Write("{0:f2} ", positiveNumbers[i]);
    }
    Console.WriteLine();

    Console.WriteLine("Массив с отрицательными числами: ");
    for (int i = 0; i < negativeNumbers.Length; ++i)
    {
      Console.Write("{0:f2} ", negativeNumbers[i]);
    }
  }
}