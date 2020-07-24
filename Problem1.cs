using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("How many students are there in class?");
    int num = Convert.ToInt32(Console.ReadLine());
    List<int> Marks = new List<int>();
    List<int> Failed = new List<int>();
    Console.WriteLine ("Enter Marks out of 100 for {num} students");
    for(int i=0;i<num;i++)
      Marks.Add(Convert.ToInt32(Console.ReadLine()));
    int cutoff=35;
    int sum_passing=0, num_passing=0;
    double avg_passing=0;

     for(int j=0;j<Marks.Count;j++){
       if(Marks[j]<35) Failed.Add(Marks[j]);
        else{
          num_passing++;
          sum_passing+=Marks[j];
       }
     }

     avg_passing=sum_passing/num_passing;
    Console.WriteLine("Average marks of passed students is "+avg_passing);
    
  }
}