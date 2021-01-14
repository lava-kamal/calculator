using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
       Console.WriteLine(" What is your age  ");
var read = Console.ReadLine();
var age = Int32.Parse(read);
var date = 2021 ;
var born =  date - age;

Console.WriteLine($" you are  born on {born} ");

        }
    }
}
