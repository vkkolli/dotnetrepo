using System;

public class EnumExample{

    public enum Season {
        WINTER = 10,
        SPRING,
        SUMMER,
        FALL
    }
    public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat }; 
    /* public static void Main(){

        int x = (int)Season.WINTER;
        int y = (int)Season.SUMMER;
        
        Console.WriteLine(x);
        Console.WriteLine(y);

        int d1 = (int)Days.Sun;  
        int d2 = (int)Days.Mon;  
        int d3 = (int)Days.Sat;  
        Console.WriteLine("Sun = {0}", d1);  
        Console.WriteLine("Mon = {0}", d2);  
        Console.WriteLine("Sat = {0}", d3);

        foreach (string s in Enum.GetNames(typeof(Days)))  
        {  
            Console.WriteLine(s);  
        }  

        foreach (int item in Enum.GetValues(typeof(Days)))
        {
            Console.WriteLine(item);
        }

    } */
}