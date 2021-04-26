using System.IO;
using System;

class pgm
{
    int a;
    int b ;
    pgm(int _a , int _b){
        a= _a;
        b= _b;
    }
    
    public static pgm operator*(pgm _obj1,pgm _obj2){
        pgm _obj3 = new pgm(0,0);
        _obj3.a = _obj1.a * _obj2.a ;
        _obj3.b = _obj1.b * _obj2.b ;
        return _obj3;
    }
    
    public static void show(pgm _obj){
        Console.WriteLine("a="+_obj.a);
         Console.WriteLine("b="+_obj.b);
    }
  
    public static void Main()
    {
        pgm a1 = new pgm(1,2);
        pgm a2 = new pgm(2,4);
        pgm a3 = new pgm(1,2);
        a3 = a1 * a2 ;
        pgm.show(a3);
        
    }
}