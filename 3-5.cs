using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace Day_3
{
    //static keyword
    //by default thease are selead clasess--cannot inherit and cannot create a object
    static class Class12
    {
        static Class12()
        {
            Console.WriteLine("Hi i am constructor");
        }
        public static string Topic = "Static Class";
        public static void sum()
        {
            Console.WriteLine("Hi ! i am a static function");
        }
    }
    class Client
    {
        public static void Main()
        {
             Class12.sum();
            //Console.WriteLine(Class12.Topic);
            Console.ReadLine();
           
        }
    }
}