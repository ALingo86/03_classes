using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes.Classes
{
    public enum VehicleType { Car, Truck, SUV, Motorcycle, Spaceship, Helicopter};

    // A class is a definition for a custom type, or like a template
    public class Vehicle
    {

        //Properties (public-facing variables)
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }

        public VehicleType Type { get; set; }



    }
}
