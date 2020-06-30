using System;  
namespace LambdaExpressions  
{  
    class Program  
    {  
        delegate int Square(int num);  
        public delegate void AnonymousFun();  
       /*  static void Main(string[] args)  
        {  
            Square GetSquare = x => x * x;  
            int j = GetSquare(5);    
            Console.WriteLine("Square: "+j);  
            AnonymousFun fun = delegate () {  
                Console.WriteLine("This is anonymous function");  
            };  
            fun();  
        } */  
    }  
}  