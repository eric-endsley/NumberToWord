using System;

namespace NTW
  {
    public class Program
    {
      static void Main()
      {
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(NumberWord.Convert(number));
      }
    }
  }