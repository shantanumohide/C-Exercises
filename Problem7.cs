using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    // int[] Count = new int[256];
    char[] Alphabets = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

    Console.WriteLine ("Enter a string in lowercase");
    string str = Console.ReadLine();

    // var Counts = Alphabets.GroupBy(a=>str.Where(f=>f==a).Count()).OrderBy(a=>a.Key).ToList();
    var Frequency = Alphabets.Select(a=>str.Where(f=>f==a).Count()).ToList();
    char max_char = Alphabets[Frequency.IndexOf(Frequency.Max())];

    Console.WriteLine("The most frequent character in the string is: "+max_char);
   

    // foreach(var count in Counts){
    //     Console.Write(count.Key+" ");
    //     foreach(char ch in count){
    //         Console.WriteLine(ch);
    //     }
    // }

    // for(int i=0;i<str.Length;i++) Count[str[i]]++;

    // int max=0;
    // char max_char=' ';

    // for(int i=0;i<str.Length;i++){
    //   if(Count[str[i]]>=max){
    //     max=Count[str[i]];
    //     max_char=str[i];
    //   } 
    // }
    // Console.WriteLine("The most frequent character in the string is: "+max_char);
    
  }
  
}