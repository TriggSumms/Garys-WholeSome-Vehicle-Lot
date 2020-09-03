using System;



namespace GarysCars {
    public interface IElectricVehicle {
        int CurrentChargePercentage {get; set;}
        public void ChargeBattery();
    }

}