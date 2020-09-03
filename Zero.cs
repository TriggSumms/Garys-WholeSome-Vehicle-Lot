using System;


namespace GarysCars
{

        public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
        {
            public double BatteryKWh { get; set; }

            public int CurrentChargePercentage {get; set;}

            public void ChargeBattery()
            {
                CurrentChargePercentage= 100;
            }
           public override void Drive()
           {
               Console.WriteLine($"The {Color} Zero moto scoots by. ");
           } 
             public override void Turn(string specificTurn)
           {
               Console.WriteLine($"The {Color} Zero moto  takes a {specificTurn}. ");
           } 
            public override void Stop()
           {
               Console.WriteLine($"The {Color} Zero moto might scoot by another day. ");
           } 

        }
    
}