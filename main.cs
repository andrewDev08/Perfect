using System;
//20231007_AndrewHorton_Exercise4.1
class Program {
  public static void Main (string[] args) {
    int integerTotal = 0;
    int inputValue = 0;
    int y = 0;
    int remainder = 0; 
    
    Console.WriteLine("Please enter the number:");
    var x = Console.ReadLine();
  
    if (int.TryParse(x, out inputValue)){}
    else {
      Console.WriteLine("Please enter a number" );
    }

    
    while (integerTotal < inputValue)
    {
      y++;
      remainder = inputValue%y;
      if (remainder == 0 )
      {
        integerTotal = integerTotal + y; 
      }
      
    }
    if (integerTotal == inputValue)
    {
      Console.WriteLine("Perfect Number");
    }
    else
    {
      Console.WriteLine("Not a Perfect Number");
    }
  }
}