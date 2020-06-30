using System;

public class InvalidAgeException : Exception {

    public InvalidAgeException(String msg)
        : base(msg) {
    }
}
class TestUserDefinedExcep{
    static void validate(int age){
        if(age < 18 ){
            throw new InvalidAgeException("You are not supposed to vote");
        }
    }
    /* public static void Main(String[] args){
        try{
            validate(20);
            validate(16);
        } catch (InvalidAgeException msg){
            Console.WriteLine(msg);
        } Console.WriteLine("Exception handled Rest of the code");
        
        Console.WriteLine("Exception handled Rest of the code");
    } */
}