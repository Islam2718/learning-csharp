﻿using System;
using System.ComponentModel;
using System.Xml.Schema;

class Person {
    private static string name = "Is";
    public static int age = 33;
    protected static string nationalId = "1234567890";
    private static int phoneNumber = 1234567890;

    public string Name {
        get{return name;} 
        set{if(value.Length >= 10) name = value;}
    }
    public int PhoneNumber { 
        get{return phoneNumber;} 
        set{if(value > 0) phoneNumber = value;} 
    }

    public Person() {
        Console.WriteLine("I am trying to be a Full-Stack Developer :)");
        Display();
    }

    public void Display() {
        Console.WriteLine("My Name is: " + name);
        Console.WriteLine("I am " + age + " Years old");
        NationalIdPublish();
    }

    private void NationalIdPublish() { 
        Console.WriteLine("National Id =" + nationalId);
    }    
}

class Test {
    public static void Main(string[] args) {
        Person person = new Person();
        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + Person.age); 
        Console.WriteLine("Phone: " + person.PhoneNumber);
    }
}
//  readonly properties << Next >>