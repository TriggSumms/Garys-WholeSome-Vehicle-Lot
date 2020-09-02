using System;


namespace GarysCars
{

        public class Zero : Vehicle // Electric motorcycle
        {
            public double BatteryKWh { get; set; }

            public void ChargeBattery()
            {
                // method definition omitted
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