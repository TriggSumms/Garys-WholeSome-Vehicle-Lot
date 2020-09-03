using System;
using System.Collections.Generic;

namespace GarysCars
{
    public class Vehicle
    {
        public string Color { get; set; }
        public string MaximumOccupancy { get; set; }

        List<IElectricVehicle> ElectricVehicles = new List<IElectricVehicle>();
        List<IGasVehicle> GasVehicles = new List<IGasVehicle>();

        public void ChargeBattery()
        {
           
        }

        public void RefuelTank()
        {
           
        }
        public virtual void Drive()
        {
            Console.WriteLine($"The {Color} scoots by. ");
        }
        public virtual void Turn(string specificTurn)
        {
            Console.WriteLine($"The {Color} takes a {specificTurn}. ");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"The {Color} might scoot by another day. ");
        }

    }
}