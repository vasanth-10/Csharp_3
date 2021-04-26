using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace Day_3
{
    class Shape
    {
        //private members----Abstraction is implemeted here---Data hiding
        double _width;
        double _length;
        //Default Constructor
        public Shape()
        {
            //Default values
            Width = Length = 0.0;
        }
        //Parametrised constructor
        public Shape(double w,double l)
        {
            Width = w;
            Length = l;
        }
        //For Square
        public Shape(double y)
        {
            Width = Length = y;
        }
        //Properties --properties
        public double Width
        {
            get { return _width; }
            set
            {
                _width = value < 0 ? -value:value;
            }
        }
        public double Length
        {
            get { return _length; }
            set
            {
                _length = value < 0 ? -value : value;
            }
        }
        public void DisplayValues()
        {
            Console.WriteLine("Width and Length are "+Width+" and "+Length);
        }
    }
    class Rectange:Shape
    {
        string Style;
        public Rectange()
        {
            Style = "";
        }
        public Rectange(String s,double w,double l):base(w,l)
        {
            Style = s;
        }
        public Rectange(double y):base(y)
        {
            Style = "square";
        }
        public double Area()
        {
            return Width * Length;
        }
        public void DisplayStyle()
        {
            Console.WriteLine("Rectangle is "+Style);
        }
    }
    class ColorRectange:Rectange
    {
        string rcolor;
        public ColorRectange(string c,string s,double w,double l):base(s,w,l)// This base keyword will
            //Rectangle class constructor
        {
            rcolor = c;
        }
        public void DisplayColor()
        {
            Console.WriteLine("Color is "+rcolor);
        }
    }
    class Client
    {
        static void Main()
        {
            ColorRectange r1 = new ColorRectange("blue","Rectangle",2.0,3.0);
            ColorRectange r2 = new ColorRectange("black", "Square", 2.0, 2.0);
            Console.WriteLine("Details of r1: ");
            r1.DisplayStyle();
            r1.DisplayValues();
            r1.DisplayColor();
            Console.WriteLine("Area is : "+r1.Area());

 

            Console.WriteLine("------------------------------------------------------------------");

 

            Console.WriteLine("Details of r2: ");
            r1.DisplayStyle();
            r1.DisplayValues();
            r1.DisplayColor();
            Console.WriteLine("Area is : " + r2.Area());
           
            Console.ReadLine();
        }
    }
}