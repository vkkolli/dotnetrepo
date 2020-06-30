using System;

namespace Sitecore
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            const string V = "Hi";
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder:  " + e);
            Console.WriteLine($"Hello World! {V}" + V);
            
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            int intmax = int.MaxValue;
            int intmin = int.MinValue;
            Console.WriteLine($"The range of int is {intmin} to {intmax}");

            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"The name {firstFriend} has {firstFriend.PadLeft(10)} {firstFriend.IndexOf('I')} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
        }
    }
    public class Student  
 {  
     int id;//field or data member   
     String name;//field or data member

    public static void main(String[] args){
        Student s1 = new Student();
        s1.id = 10;
        s1.name = "Vijay";
        Console.WriteLine(s1.id +" " +  s1.name);
    }  
 } 
}
