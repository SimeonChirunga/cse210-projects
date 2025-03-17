using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fraction Project.");
        Fraction fra1 = new Fraction();
        Console.WriteLine(fra1.GetFractiontring());
        Console.WriteLine(fra1.GetDecimalValue());
        Fraction fra2 = new Fraction(2);
        Console.WriteLine(fra2.GetFractiontring());
        Console.WriteLine(fra2.GetDecimalValue());
       
        Fraction fra3 = new Fraction(3, 4);
        Console.WriteLine(fra3.GetFractiontring());
        Console.WriteLine(fra3.GetDecimalValue());
    }
   
  

}