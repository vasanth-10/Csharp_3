using System.IO;
using System;

class Program
{
    static void Main()
    {
        string a = "This is a bad color ";
        if(a.Contains("is")){
            Console.WriteLine("It is present");
        }
        else{
             Console.WriteLine("It is not present");
        }
    }
}