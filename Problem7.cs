using System;
//using System.Linq;
class MainClass {
  public static void Main (string[] args) {
    int[] Count = new int[256];

    Console.WriteLine ("Enter a string");
    string str = Console.ReadLine();

    for(int i=0;i<str.Length;i++)
      Count[str[i]]++;

    int max=0;
    char max_char=' ';

    for(int i=0;i<str.Length;i++){
      if(Count[str[i]]>=max){
        max=Count[str[i]];
        max_char=str[i];
      } 
    }
    Console.WriteLine(max_char);
    
  }
  
}