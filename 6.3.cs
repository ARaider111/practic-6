using System;

class Program
{
  public static void Main (string[] args)
  {
    int n = 0;
    Console.WriteLine ("Введите число: ");
    n = int.Parse(Console.ReadLine());
    if (n % 2 == 0)
    {
      Console.WriteLine("Число четное");
    }
    else
    {
      Console.WriteLine("Число нечетное");
    }

    if (n % 10 == 0)
    {
      Console.WriteLine("Число кратно 10");
    }
    else
    {
      Console.WriteLine("Число не кратно 10");
    }
  }
}