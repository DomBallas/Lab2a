using System;

class MainClass {
  public static void Main (string[] args) {
  Console.WriteLine("Enter name of item");   
 string itemName = Console.ReadLine(); 
Console.WriteLine("item is: " + itemName);

Console.WriteLine("Enter selling price");
double sp = Convert.ToDouble
(Console.ReadLine());

Console.WriteLine("Enter quantity");
double quantity = Convert.ToDouble
(Console.ReadLine());

double fp = (sp*quantity);

Console.WriteLine("Final price is $ " + fp);
}
}
