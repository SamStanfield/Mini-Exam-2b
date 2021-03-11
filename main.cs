using System;

class MainClass {
  public static double DetermineHypotenuse(int side1, int side2){
    double hypotenuse = Math.Sqrt((side1*side1) + (side2 * side2));
    return hypotenuse;


  }
  
  
  public static void Main (string[] args) {
    int l,w= 0;
    Console.WriteLine("What are the lenght's for side 1 and side 2?");
    l = Convert.ToInt32(Console.ReadLine());
    w = Convert.ToInt32(Console.ReadLine());
    double h = DetermineHypotenuse(l,w);
    Console.WriteLine("The hypotenuse is " + h);
  }
}