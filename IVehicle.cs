using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReviewDemo
{
    internal interface IVehicle
    {
        void StartEngine();
        void StopEngine();
        void Accelerate();
        void Brake();

        void PrepareCoffee();
        void AddCoffee();
    }
}
