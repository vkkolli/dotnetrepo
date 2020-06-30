using System;

public class Trycatch{

    /*Even though we have exception still it executes and 
    prints Rest of the code
    output:
    System.DivideByZeroException: Attempted to divide by zero.
    at Trycatch.Main() in D:\Projects\Sitecore\exceptionHandling\trycatch.cs:line 9
    Rest of the code*/
    /*  static void Main(){
        int i = 10;
        int j = 0;
        try{
            int k = i/j;
            Console.WriteLine("value of i got exception but handled");
        } catch (Exception e){
            Console.WriteLine(e);
        } finally { Console.WriteLine("Finally block is executed"); }  
        Console.WriteLine("Rest of the code"); 
        Console.WriteLine("Rest of the code"); 
        /*
        System.DivideByZeroException: Attempted to divide by zero.
        at Trycatch.Main() in D:\Projects\Sitecore\exceptionHandling\trycatch.cs:line 15
        Finally block is executed
        Rest of the code
        Rest of the code
    }  */
}