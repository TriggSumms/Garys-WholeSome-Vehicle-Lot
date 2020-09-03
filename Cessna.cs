using System;

namespace GarysCars
{

    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
          CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {Color} Cessna planeboi scoots by. ");
        }
        public override void Turn(string specificTurn)
        {
            Console.WriteLine($"The {Color} Cessna planeboi takes a {specificTurn}. ");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {Color} Cessana planeboi might scoot by another day. ");
        }
    }

}