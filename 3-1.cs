using System.IO;
using System;

class Program
{
    void sum(int a, int b)
    {
        Console.WriteLine("Sum of the value is  " +(a+b));
    }
     void sum(double a, double b)
    {
        Console.WriteLine("Sum of the value is  " +(a+b));
    }
     void sum(string a, string b)
    {
        Console.WriteLine("Sum of the integer is " +(a+b));
    }
    static void Main()
    {
        Program pgm = new Program();
        Console.WriteLine("Enter the value of a and b");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        pgm.sum(a,b);
        pgm.sum(a.ToString(),b.ToString());
        pgm.sum(Convert.ToDouble(a),Convert.ToDouble(b));
        
    }
}