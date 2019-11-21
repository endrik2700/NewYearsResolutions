using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace NewYearResolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Please enter your new year resolutions, seprated by a comma");
            string  input  = Console.ReadLine();
            string [] resolutionStrings =  input.Split(",");
            NewYearResolutions res = new NewYearResolutions ();
            res.addToResolutionList(resolutionStrings);
           
            string path = $"@C:/Users/endri/Desktop/data.txt";
            File.AppendAllLines(path,res.resList);
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(lines);
            }
               

            Console.ReadLine();



        }
    }
    class NewYearResolutions
    {
        public string resolution;
       public  List<string> resList = new List<String>();

        public NewYearResolutions ( )
        {
        }

        

        public void addToResolutionList (string [] items)
        {
            foreach (string item in items)
            {

                resolution = item;
                resList.Add(resolution);
                
            }
            Console.WriteLine("These are your new year's resolutions: ");
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        
        
    }
}
