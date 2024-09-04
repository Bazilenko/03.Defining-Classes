using System;
namespace Car
{
	public class Car

	{
		string model;
		double fuel;
		double fuelConsume;
		double mileage;
		public Car(string model, double fuel, double fuelConsume, double mileage = 0)
		{
			this.model = model;
			this.fuel = fuel;
			this.fuelConsume = fuelConsume;
		}
		public string GetModel
		{
			get { return this.model; }
			set { this.model = value; }
		}
		public double GetFuel
		{
			get{ return this.fuel; }
			set{ this.fuel = value; }
		}
		public double GetFuelConsume
		{
			get{ return this.fuelConsume; }
			set { this.fuelConsume = value; }
		}
		public double GetMileage
		{
			get { return this.mileage; }
			set { this.mileage = value; }
		}
		
		public void Drive(double mil)
		{
			double fuelForDrive = fuelConsume * mil;
			if (fuelForDrive > fuel)
			{
				Console.WriteLine("Out of fuel!");
			}
			else
			{
				this.mileage += mil;
				fuel -= fuelForDrive;


			}
		}
		

		
		

		
	}
}