using System;
//program to find the larger value from two positive integer values that is in the range 20..30 inclusive, or return 0 if neither is in that range
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Write two integers");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    int max_num;
    if((num1>=20&&num1<=30)&&(num2>=20&&num2<=30)){
      if(num1>=num2) max_num=num1;
      else max_num=num2;
    }
    else max_num=0;
    Console.WriteLine(max_num);
  }
}