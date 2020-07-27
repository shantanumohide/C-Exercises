using System;

namespace HelloWorld
{
    class Program
    {
         public static void Main (string[] args) {
          IFile file1 = new Fileinfo("File1");
          Fileinfo file2 = new Fileinfo("File2");
          file1.Readfile();
          file1.Writefile("Content");
          file1.Searchfile("Mike");
          file2.Readfile();
          file2.Writefile("Content");
          file2.Searchfile("John");
        }
    }


    interface IFile{
        void Readfile();
        void Writefile(string text);  
        void Searchfile(string keyword);
    }


    public class Fileinfo : IFile
    {

        public string Filename;
        
        public Fileinfo(string aFilename){
          Filename = aFilename;
        } 
        public void Readfile(){
          Console.WriteLine($"Reading {Filename}");
        }

        public void Writefile(string text){
         Console.WriteLine($"Writing to {Filename}");
        }

        public void Searchfile(string keyword){
          Console.WriteLine($"Searching for {keyword} in {Filename}.");
        }
        
    }

}
