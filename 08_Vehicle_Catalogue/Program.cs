using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] tokens = input
                    .Split("/")
                    .ToArray();

                string type = tokens[0];

                if (type == "Car")
                {
                    string brand = tokens[1];
                    string model = tokens[2];
                    int power = int.Parse(tokens[3]);

                    Car car = new Car(brand, model, power);
                    cars.Add(car);
                }
                else if (type == "Truck")
                {
                    string brand = tokens[1];
                    string model = tokens[2];
                    int weigth = int.Parse(tokens[3]);

                    Truck truck = new Truck(brand, model, weigth);
                    trucks.Add(truck);
                }
            }
            if (cars.Count > 0)
            {
                cars = cars.OrderBy(x => x.Model).ToList();

                Console.WriteLine("Cars:");

                foreach (Car car in cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.Power}hp");
                }
            }
            if (trucks.Count>0)
            {
                trucks = trucks.OrderBy(x => x.Model).ToList();

                Console.WriteLine("Truck");

                foreach (Truck truck in trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weigth}kg");
                }
            }
        }

        class Car
        {
            public Car(string brand,string model,int power)
            {
                Brand = brand;
                Model = model;
                Power = power;
            }
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Power { get; set; }
        }

        class Truck
        {
            public Truck(string brand,string model,int weigth)
            {
                Brand = brand;
                Model = model;
                Weigth = weigth;
            }
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weigth { get; set; }
        }
    }
}
