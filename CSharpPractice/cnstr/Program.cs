using System;  
   public class Employee  
    {  
        public Employee()  
        {  
            Console.WriteLine("Constructor Invoked");  
        }  
        ~Employee()  
        {  
            Console.WriteLine("Destructor Invoked");  
        }  
    }  
   class TestEmployee{  
       public static void Main(string[] args)  
        {  
            Employee e1 = new Employee();  
            Employee e2 = new Employee();  
            Details();
            GC.Collect();
            Console.ReadLine();
        }  
        public static void Details()

        {

            // Created instance of the class

            Employee user = new Employee();

        }
    }  