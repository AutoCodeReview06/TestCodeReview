using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReviewDemo
{
    internal class Vehicle : IVehicle
    {
        // Manufacturer of the vehicle
        public string Manufacturer { get; set; }

        // Model of the vehicle
        public string model { get; set; }

        // Year of manufacture
        public int year { get; set; }

        // Price of the vehicle
        public double Price { get; set; }

        // Starts the vehicle's engine
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }

        // Stops the vehicle's engine
        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }

        // Accelerates the vehicle
        public void Accelerate()
        {
            Console.WriteLine("Vehicle is accelerating.");
        }

        // Applies the vehicle's brakes
        public void Brake()
        {
            Console.WriteLine("Vehicle is braking.");
        }

        private void CalculateSpeed(int distance, int time)
        {
            try
            {
                var speed = time / distance;
                Console.WriteLine($"Speed={speed}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public void PrepareCoffee()
        {
            throw new NotImplementedException();
        }

        public void AddCoffee()
        {
            throw new NotImplementedException();
        }
    }
}
