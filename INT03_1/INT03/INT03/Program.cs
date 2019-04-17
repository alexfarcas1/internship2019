using INT03.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace INT03
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Solver s = new Solver();

            //string input = @"C:\Users\Alex\Desktop\COERA\internship2019\INT03_1\INT03\INT03\input.json";
            //string output = @"C:\Users\Alex\Desktop\COERA\internship2019\INT03_1\INT03\INT03\output.json";

          string input = "input.json";
          string output = "output.json";

            s.solutie(input,output);

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
