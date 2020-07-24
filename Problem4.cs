using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a string");
    string text = Console.ReadLine();
    Console.WriteLine("Enter index");
    int index = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(text.Substring(index,2));
  }
}