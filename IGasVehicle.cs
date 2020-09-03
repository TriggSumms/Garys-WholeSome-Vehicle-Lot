using System;



namespace GarysCars {
    public interface IGasVehicle {
        int CurrentTankPercentage {get; set;}
        public void RefuelTank();
    }

}
