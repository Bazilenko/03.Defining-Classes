using System;
	public class Person
	{
		public Person() : this("No Name", 1) { }
		public Person(int age) : this("No Name", age) { }
		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public string Name
		{get; set;}

		public int Age {get; set;}

		public void PrintInfo()
		{
			Console.WriteLine($"Name: {Name}, Age: {Age}");
		}
	}
