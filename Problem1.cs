using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2.cs
{

    // public class Classroom{
    //     public int 
    // }
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine ("How many students are there in class?");
            int num = Convert.ToInt32(Console.ReadLine());
            List<int> Marks = new List<int>();
            Console.WriteLine ($"Enter Marks out of 100 for {num} students");
            for(int i=0;i<num;i++)
            Marks.Add(Convert.ToInt32(Console.ReadLine()));
            int sum_passing = 0, num_passing = 0;
            double avg_passing=0;
            int cutoff = 35;

            //Passed students
            var Passed_students = Marks.Where(n => n>=cutoff).Select(n=>new {id=Marks.IndexOf(n), Score=n}).ToList();
            // sum_passing = Passed_students.Sum();
            num_passing = Passed_students.Count();
            foreach(var student in Passed_students){
                sum_passing+=student.Score;
            }
            avg_passing=sum_passing/num_passing;
            Console.WriteLine("Average marks of passed students is "+avg_passing);
            
            // Console.WriteLine(Passed_students[0]);

    //         for(int j=0;j<Marks.Count;j++){
    //         //  if(Marks[j]<35) Failed.Add(j);
    //         // else{
    //             if(Marks[j]>=35){
    //                 num_passing++;
    //                 sum_passing+=Marks[j];}
    //   //        }
    //         }

            //Failed students
            var Failed_students = (Marks.Where(n => n < cutoff).Select(n=>new {id=Marks.IndexOf(n), Score=n})).ToList();
            foreach (var student in Failed_students){
                Console.WriteLine(student.id);
            }
           
            
        }
    }
}
