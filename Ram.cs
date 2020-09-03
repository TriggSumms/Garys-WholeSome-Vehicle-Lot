using System;

namespace GarysCars
{

    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public string CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {Color} Ram truck scoots by. ");
        }
        public override void Turn(string specificTurn)
        {
            Console.WriteLine($"The {Color} Ram truck  takes a {specificTurn}. ");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {Color} Ram truck might scoot by another day. ");
        }
    }

}