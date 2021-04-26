using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace Day_3
{
    class Class14
    {
        public static void Main()
        {
            string inputString = "hhnmnaab";

 

            int index = 0;
            char[] outputString = inputString.ToArray();
            for (int i = 0; i < outputString.Length; i++)
            {
                int j;
                for (j = 0; j < i; j++)
                {
                    if(outputString[i]== outputString[j])
                    {
                        break;
                    }
                }
                if(j==i)
                {
                    outputString[index++] = outputString[index];
                }
            }
            char[] final = new char[index];
            Array.Copy(outputString, final, index);
            Console.WriteLine(string.Join("", final));

 

            Console.ReadLine();
        }

 


    }
}