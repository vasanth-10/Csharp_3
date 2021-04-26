using System.IO;
using System;

class Program
{
    static void Main()
    {
        string a = "This Is a Bad Color ";
        Char [] arr;
        arr = a.ToCharArray();
        for (int i=0; i<arr.Length;i++){
             if(Char.IsLower(arr[i])){
                 Console.Write(Char.ToUpper(arr[i]));
             }
            else{
                 Console.Write(Char.ToLower(arr[i]));
            }
        }
       
           
    }
}