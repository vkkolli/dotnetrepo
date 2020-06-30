using System;  
using System.Collections.Generic;
namespace CSharpFeatures  
{  
    class Student  
    {  
        public int ID { get; set; }  
        public string Name { get; set; }  
        public string Email { get; set; }  

        public string displayName(string name="test", string email="test@mail.com"){
            return ("Name  "+name + " Email: "+ email);
        }
    }  
    class ObjectInitializer  
    {  
        /* public static void Main(string[] args)  
        {  
            // Using Object Initialilzer  
            Student student = new Student { ID=101, Name="Rahul", Email="rahul@example.com" };  
            // Displaying Initialized Values  
            Console.WriteLine(student.ID);  
            Console.WriteLine(student.Name);  
            Console.WriteLine(student.Email);  

            List<Student> students = new List<Student> {
                new Student {ID = 101, Name = "Vijay", Email = "vij@gmail.com"},
                new Student {ID = 102, Name = "Kumar", Email = "kumar@gmail.com"},
                new Student {ID = 103, Name = "Vk", Email = "kolli@gmail.com"}
            };
            foreach(Student s in students){
                Console.WriteLine(s.ID);
                Console.WriteLine(s.Name);
                Console.WriteLine(s.Email);
            }
            var athi = student.displayName(name: student.Name, email: student.Email);
            var athi1 = student.displayName(name: student.Name);
            var athi2 = student.displayName();
            Console.WriteLine("variable ::"+ athi + athi1 + athi2);
        }   */
    }  
} 