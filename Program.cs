using System;

namespace Exception1
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);                
            }
            catch(DivideByZeroException e){ //use to catch de exception and give a better message
                Console.WriteLine("Error! " + e.Message);
            }
        }
    }
}
