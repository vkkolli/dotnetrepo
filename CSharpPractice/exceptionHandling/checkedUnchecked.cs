using System;

public class CheckedUnchecked{

    static void Main(){
        
        try{
            checked {
            int i = int.MaxValue;
            Console.WriteLine(i+2);
            //In this case the compiler throws overflow exception using checked keyword
            } 
        } catch(SystemException e){Console.WriteLine(e);}
        unchecked {
            int j = int.MaxValue;
            Console.WriteLine(j+2);
            //in this case the compiler doesn't throw overflow exception and returns the truncated or wrong value
        }
    }
}