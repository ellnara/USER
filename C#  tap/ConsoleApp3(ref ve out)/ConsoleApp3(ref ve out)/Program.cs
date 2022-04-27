using System;

namespace ConsoleApp3_ref_ve_out_
{
    class Program
    {
        static void Main(string[] args)
        {

        



        }
        static void swap1(ref int  n , ref int m)   
        {
            
            n = n + m;
            m = n - m;
            n = n - m;
            Console.WriteLine( n+"n dir "+m+" m dir");

        }

   
    }
}
