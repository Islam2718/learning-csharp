using System;
class MyClass{
    public static void Main(string[] args){

        int age = 10;
        double height = 5.6;
        string name = "Islam Hossain";
        char grade = 'A'; //single quotation for character
        bool isMarried = false; //bool stored true or false...

        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Married: " + isMarried);

        string? inputName = Console.ReadLine();
        Console.WriteLine("Hello " + inputName);

    }
}