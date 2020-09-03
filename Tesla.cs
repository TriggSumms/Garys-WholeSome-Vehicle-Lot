using System;

namespace GarysCars
{

    public class Tesla : Vehicle, IElectricVehicle // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public string CurrentChargePercentage { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"The {Color} Tesla car scoots by. ");
        }
        public override void Turn(string specificTurn)
        {
            Console.WriteLine($"The {Color} Tesla car  takes a {specificTurn}. ");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {Color} Tesla  might scoot by another day. ");
        }
    }

}