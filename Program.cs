﻿namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
     Menu();

    }

    static void Menu(){
        Console.Clear();

        Console.WriteLine("1 - Sum");
        Console.WriteLine("2 - Sub");
        Console.WriteLine("3 - Div");
        Console.WriteLine("4 - Multi");

        Console.WriteLine("Choose your option: ");
        int option = int.Parse(Console.ReadLine());


         
          switch(option){
             case 1:
                Sum();
                break;

             case 2: 
                Sub();
                break;
            
             case 3:
                Division();
                break;

             case 4:
                Multi();
                break;
                  
          }
    }
    static void Sum()
    {
        Console.Clear();

        Console.WriteLine("First value: ");
        float firstValue = float.Parse(Console.ReadLine());
        //float.Parse(Console.ReadLine());

        Console.WriteLine("Second value: ");
        float secondValue = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float result = firstValue + secondValue;
        Console.WriteLine($"Sum output is: {result}");
        Console.ReadKey();
    }

    static void Sub()
    {
        Console.Clear();

        Console.WriteLine("First value: ");
        float firstValue = float.Parse(Console.ReadLine());
        //float.Parse(Console.ReadLine());

        Console.WriteLine("Second value: ");
        float secondValue = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float result = firstValue - secondValue;
        Console.WriteLine($"Sub output is: {result}");
        Console.ReadKey();
    }

    static void Division(){
        Console.Clear();


        Console.WriteLine("First value: ");
        float firstValue = float.Parse(Console.ReadLine());

        Console.WriteLine("Second value: ");
        float secondValue = float.Parse(Console.ReadLine());

        float division = firstValue / secondValue;

        Console.WriteLine($"Division result is {division}");
        Console.ReadKey();
    }

    static void Multi()
    {
        Console.Clear();

        Console.WriteLine("First value: ");
        float firstValue = float.Parse(Console.ReadLine());

        Console.WriteLine("Second value: ");
        float secondValue = float.Parse(Console.ReadLine());

        float multi = firstValue * secondValue;

        Console.WriteLine($"Multi result is {multi}");

        Console.ReadKey();
    }

}
