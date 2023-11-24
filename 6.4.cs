using System;

class Program
{
  public static void Main (string[] args)
  {
    int n = 0, a = 0;
    Console.WriteLine ("Введите количество чисел:");
    n = int.Parse(Console.ReadLine());
    int[] numbers = new int[n];
    Console.WriteLine ("Введите положительные числа:");
    for (int i = 0; i < numbers.Length; ++i)
    {
      n = int.Parse(Console.ReadLine());
      if (n < 0)
      {
        Console.WriteLine("Число отрицательное!");
        return;
      }
      numbers[i] = n;
    }

    Console.WriteLine ("Введите делитель a:");
    a = int.Parse(Console.ReadLine());
    if (a < 0)
    {
      Console.WriteLine("Число отрицательное!");
      return;
    }

    int sum = 0;
    for(int i = 0; i < numbers.Length; ++i)
    {
      if(numbers[i] % a == 0)
      {
        sum += numbers[i];
      }
    }
    Console.WriteLine($"Сумма равна: {sum}");
  }
}