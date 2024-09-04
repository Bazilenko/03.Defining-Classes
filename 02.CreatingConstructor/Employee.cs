using System;
 
public class Employee
{
		string name;
		decimal salary;
		string pos;
		string departament;
		string mail;
        int age;
        public Employee(string name, decimal salary, string pos, string departament, string mail = "n/a", int age = -1)
		{
			this.name = name;	
			this.salary = salary;
			this.pos = pos;
			this.departament = departament;
			this.mail = mail;
			this.age = age;
		}
		public decimal GetSalary
		{
			get;
			set;
	
		}
		public string GetDepartament
		{
			get;
			set;
		}

	}
