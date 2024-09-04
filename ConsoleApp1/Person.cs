using System;
class Percon
{
    static void Main()
    {
        int n;
        Console.WriteLine("Enter quantity(n) of members: ");
        n = int.Parse(Console.ReadLine());
        Family fam = new Family();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter name: ");
            string nm = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int a = int.Parse(Console.ReadLine());
            Person p = new(nm,a);
            fam.AddMember(p);
        }
        Console.WriteLine("Task1: ");
        Person student = new();
        Person student1 = new("Gosho", 20) ;
        Person student2 = new("Stamat", 43);
        student.PrintInfo();
        student1.PrintInfo();
        student2.PrintInfo();
        Console.WriteLine("The oldest member:");
        Person oldest = new Person();
        oldest = fam.GetOldestMember();
        oldest.PrintInfo();
    }
}
