using System;
// a program to check if a number is present in a given array of integers
class MainClass {
  public static void Main (string[] args) {
    int[] numArray = new int[4]; 
    Console.WriteLine ("Enter 4 numbers to be stored in an array");
    for(int i=0;i<4;i++){
      numArray[i]=Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Enter number to be searched in array");
    int num = Convert.ToInt32(Console.ReadLine());
    bool isFound=false;
    int itr=0;
    while(isFound==false&&itr<4){
      if(numArray[itr]==num) isFound=true;
      itr++;
    }
    Console.WriteLine(isFound);
  }
}