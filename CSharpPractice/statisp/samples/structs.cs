/* C# Structs
In C#, classes and structs are blueprints that are used to create instance of a class.
 Structs are used for lightweight objects such as Color, Rectangle, Point etc.
Unlike class, structs in C# are value type than reference type. 
It is useful if you have data that is not intended to be modified after creation of struct. */
using System;
public struct Rectangle{
    public int width, height;

    public Rectangle(int width, int height){
        this.width = width;
        this.height = height;
    }

    public void area(){
        Console.WriteLine("Area of rectangle..." + this.width*this.height );
    }
}

class TestRectangle{

    /* public static void Main(String[] args){
        Rectangle r = new Rectangle(5,6);
        r.area();
    } */
}