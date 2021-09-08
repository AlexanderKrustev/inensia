using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../input.txt";
            var jsonText = File.ReadAllText(filePath);
            var actors = JsonConvert.DeserializeObject<IList<MovieStar>>(jsonText);
           
            foreach(var actor in actors)
            {
                Console.Write(actor.ToString());
            }



        }
    }
}
