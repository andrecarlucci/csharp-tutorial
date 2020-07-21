using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace SuperAtlas
{
    class Program
    {
        static void Main(string[] args)
        {
            var andre = new Person("andre", 22);
            var goutam = new Person("goutam", 99);
            var jeroen = new Person("jeroen", 78);

            var people = new Person[2];
            people[0] = andre;
            people[1] = goutam;

            var list = new List<Person>();
            list.Add(andre);
            list.Add(goutam);
            list.Add(jeroen);

            var avg = list.Average(p => p.Age);

            foreach(var p in people) {
                p.SayYourName();
                if(p.CanDrive()) {
                    Console.WriteLine("Can drive");
                }
                else {
                    Console.WriteLine("Sorry!");
                }
            }

            Console.WriteLine(avg);

            File.WriteAllText("config.txt", andre.Name);
            var files = Directory.GetFiles(".");
            foreach(var file in files) {
                Console.WriteLine("-> " + file);
            }
            var content = File.ReadAllText("Program.cs");
            content = content.Replace("andre","superman");
            Console.WriteLine(content);
        }
    }
}
