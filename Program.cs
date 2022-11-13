using System;
using System.IO;

namespace challenge
{
    class Program
    {
         static void Main(string[] args)
        {
         Console.WriteLine("Enter your sentence To rearrange it in order for you. ");
        string input = Console.ReadLine();
          string [] sub = input.Split(" ");
          if(input.Length >= 3)
          {
            for(int i =0; i < sub.Length; i++)
            {
                for(int j = 0 ;j < sub[i].Length;j++)
                {
                    Console.Write(sub[i].Substring(0,1).ToUpper() + sub[i].Substring(1,sub[i].Length-1).ToLower()+ " ");
                    if(j == 0) break;
                }
            }
          }

          


         







        //  string directory = @"C:\Users\user\Desktop\movie\NewFolder";
        //   string direct = @"C:\Users\user\Desktop\movie\class\Generate.txt";
        //  Directory.CreateDirectory(directory);
        // System.Console.WriteLine(Directory.Exists(directory));

       // File.Create(direct);


        // StreamWriter streamWriter = new StreamWriter(direct);
        // streamWriter.WriteLine("I am a boy");
        // StreamReader streamReader = new StreamReader(direct);
        // Console.Write(streamReader.ReadToEnd());
        // streamReader.Close();
         }
    }
}
