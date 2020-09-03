using System;
using System.Collections.Generic;

namespace GarysCars
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.Color = "shelly Green";
            fxs.CurrentChargePercentage = 98;

            Tesla modelS = new Tesla();
            modelS.Color = "candy-red";
            modelS.CurrentChargePercentage = 99;

            Cessna mx410 = new Cessna();
            mx410.Color = "Nasty";
            mx410.CurrentTankPercentage = 77;

            Ram rammer = new Ram();
            rammer.Color = "Church pew Gold";
            rammer.CurrentTankPercentage = 35;

            //------------------------------------------------------------------------------------------------------------------------------------------------------
            List<IElectricVehicle> ElectricVehicles = new List<IElectricVehicle>()
            {
                //fx,
                fxs,
                modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in ElectricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectricVehicle ev in ElectricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in ElectricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }
            //------------------------------------------------------------------------------------------------------------------------------------------------------

            List<IGasVehicle> GasVehicles = new List<IGasVehicle>()
            {
                rammer,
                mx410
            };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in GasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IGasVehicle gv in GasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in GasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
            //------------------------------------------------------------------------------------------------------------------------------------------------------

/*             fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            rammer.Drive();

            fxs.Turn("left");
            modelS.Turn("side");
            mx410.Turn("other-side");
            rammer.Turn("backwards");

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            rammer.Stop(); */
        }
    }
}