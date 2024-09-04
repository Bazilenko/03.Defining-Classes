using System;
using Car;
class Program
{
    static void Main()
    {
        int N;
        Console.WriteLine("Enter N: ");
        N = int.Parse(Console.ReadLine());
        Dictionary<string, Car.Car> cars = new Dictionary<string, Car.Car>();
        for (int i = 0; i < N; i++)
        {
            string[] data = Console.ReadLine().Split();
            string m = data[0];
            double f = double.Parse(data[1]);
            double fc = double.Parse(data[2]);
            cars[m] = new Car.Car(m, f, fc);
        }
        string action = "Start";
        while ((action = Console.ReadLine()) != "End")
        {
            string[] drive = Console.ReadLine().Split();
            string model = drive[1];
            double mileage = double.Parse(drive[2]);
            if (cars.ContainsKey(model)) {
                cars[model].Drive(mileage);

            }
            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.GetModel} {car.GetFuel:F2} {car.GetMileage()}");
            }



        }

    }
}