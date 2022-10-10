using System;

namespace MyLib
{
    public class Person
    {
        string name;
        int age;
        static int retirementAge = 65;
        public static int RetirementAge
        {
            get { return retirementAge; }
            set { if (value > 1 && value < 100) retirementAge = value; }
        }
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public void СheckAge(int age)
        {
            if (age >= retirementAge)
                Console.WriteLine("Уже на пенсии");
            else
                Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - age}");
        }
        public void Print2() => Console.WriteLine($"Age: {age}");
        public void Print() => Console.WriteLine($"Name: {name}");

    }
    

}
