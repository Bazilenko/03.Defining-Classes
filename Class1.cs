using System;
namespace Person { 
public Person
{
    string name;
    int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {this.name}, Age: {this.age}");
    }
}
}
