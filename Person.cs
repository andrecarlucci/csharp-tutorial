
using System;

namespace SuperAtlas
{
    public class Person {

        public static int AgeToDrive = 18;
        public int Age { get; private set;}
        public string Name { get; set;}

        public Person(string name, int age) {
            Age = age;
            Name = name;
        }

        public void SayYourName() {
            Console.WriteLine("My name is " + Name);
        }

        public bool CanDrive() {
            return Age >= Person.AgeToDrive;
        }

        public string GetFavoriteColor() {
            return "blue";
        }

    }
}