using System;
using MyLib;


namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(35,"Anna");
            person.Print();
            person.Print2();
            person.СheckAge(35);

            }


    }
    }

