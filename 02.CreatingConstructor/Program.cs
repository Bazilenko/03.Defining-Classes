using System;

namespace Company
{
    class Company
    {
        static void Main()
        {
            int N;
            Console.WriteLine("Enter quantity(N) of employee: ");
            N = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>(N);
            for (int i = 0; i < N; i++)
            {
                string[] employeeData = Console.ReadLine().Split();
                string name = employeeData[0];
                decimal salary = decimal.Parse(employeeData[1]);
                string position = employeeData[2];
                string department = employeeData[3];

                string email = "n/a";
                int age = -1;

                if (employeeData.Length == 5)
                {
                    if (int.TryParse(employeeData[4], out age))
                    {
                     
                    }
                    else
                    {
                        email = employeeData[4]; 
                    }
                }
                else if (employeeData.Length == 6)
                {
                    email = employeeData[4];
                    age = int.Parse(employeeData[5]);
                }

                employees.Add(new Employee(name, salary, position, department, email, age));
            }
            string salDepart = "";
            decimal HighestavgSalary = 0;
            for (int i = 0;i < N; i++)
            {
                decimal salary = 0;
                int k = 0;
                for (int j = 0; j < N; j++)
                {
                    if (employees[i].GetDepartament == employees[j].GetDepartament)
                    {
                        k++;
                        salary += employees[j].GetSalary;
                    }
                }
                decimal avgsalary = salary / k;
                if (avgsalary > HighestavgSalary)
                {
                    HighestavgSalary = avgsalary;
                    salDepart = employees[i].GetDepartament;
                }
            }
            Console.WriteLine("Highest average salary:" + salDepart);
        }
    }
}
