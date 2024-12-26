using System;

namespace firstnamelastname
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your FIRST name?");

            string firstname = Console.ReadLine();
            Console.WriteLine("all right "+ firstname +"!");
            Console.WriteLine("what is your LAST name?");
            string lastname = Console.ReadLine();
            Console.WriteLine("Hello " + firstname + " " + lastname+ "!");
            Console.WriteLine("YOU ARE AWESOME");
        }
    }
}
