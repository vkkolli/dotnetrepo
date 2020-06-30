using System;

namespace statisp
{
   public class Account  
    {  
        public int accno;   
        public String name;  
        public static int count=0;  

        public static float rateOfInterest = 8.8f;
        public Account(int accno, String name)  
        {  
            this.accno = accno;  
            this.name = name;  
            count++;  
        }  
          /*
          Advantage of C# static keyword
        Memory efficient: Now we don't need to create instance for accessing the static members, 
        so it saves memory. Moreover, it belongs to the type, so it will not get memory each time when instance is created.
          */
        public void display()  
        {  
            Console.WriteLine(accno + " " + name  + " " + rateOfInterest);  
        }  
   }  
   class TestAccount{  
       public static void Main(string[] args)  
        {  
            Account a1 = new Account(101, "Sonoo");  
            Account a2 = new Account(102, "Mahesh"); 
            //Account.rateOfInterest = 10.5f; 
            Account a3 = new Account(103, "Ajeet");  
            a1.display();  
            a2.display();  
            a3.display();  
            Console.WriteLine("Total Objects are: "+Account.count);  
        }  
    }  
}
