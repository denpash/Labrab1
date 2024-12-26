using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INPUTE COMMAND : ");
            string calculcstring;

            calculcstring = Console.ReadLine(); Console.WriteLine("\n");
            string[] result = calculcstring.Split(' ');
    
            float res = 0;
            
            switch (result[1]) {
                case "+":
                     res = float.Parse(result[0]) + float.Parse(result[2]);
                    Console.WriteLine("Result : " + res);
                    break;
                case "-":
                     res = float.Parse(result[0]) - float.Parse(result[2]);
                    Console.WriteLine("Result : " + res);
                    break;
                case "*":
                     res = float.Parse(result[0]) * float.Parse(result[2]);
                    Console.WriteLine("Result : " + res);
                    break;
                case "/":
                     res = float.Parse(result[0]) / float.Parse(result[2]);
                    Console.WriteLine("Result : " + res);
                    break;
                default:
                    Console.WriteLine("Wrong value!!!!");
                    break;

                    Console.WriteLine("Proggram finished!!!!!");
                    Console.WriteLine("Proggram finished!!!!!");
                    Console.WriteLine("ANOTHER CHANGE!");
            }
           
        }
    }
}
