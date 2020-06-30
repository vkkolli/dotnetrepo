using System;

    class Student{
        public int id;
        public String name;
        public float salary;
        public Student(int id, String name, float salary){
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void display(){
            Console.WriteLine("ID :"+ id + " Name: " + name + " Salary: "+ salary);
        }
        public Student(){
            Console.WriteLine("Consturctor called");
        }

        /*
        C# this - this is a keyword that refers to the current instance of the class
        It can be used to refer current class instance variable. It is used if field names (instance variables) and parameter names are same, that is why both can be distinguish easily.
        It can be used to pass current object as a parameter to another method.
        It can be used to declare indexers.
        */
        ~Student(){
            Console.WriteLine("Destructor Called");
        }
    }

    class TestStudent {
        /* public static void Main(String[] args){

            Student s1 = new Student(10,"kumar",100000f);
            Student s2 = new Student(20,"Jai",20000f);
            Student s3 = new Student();
            
            // s.id = 100;
            // s.name = "Vijay";
            // Console.WriteLine(s.id);
            // Console.WriteLine(s.name);
           // s.saveData(10,"kumar",100000f);
            s1.display();
            //s.saveData(20,"Jai",20000f);
            s2.display();
            displayObj(s1);
        } */

        public static void displayObj(Student s){

            Console.WriteLine("student obj " + s.id);

        }
    }