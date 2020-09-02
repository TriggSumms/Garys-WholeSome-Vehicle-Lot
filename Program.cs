using System;
//using System.Collections.Generic;

namespace GarysCars
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.Color = "shelly Green";
         

            Tesla modelS = new Tesla();
            modelS.Color = "candy-red";
          

            Cessna mx410 = new Cessna();
            mx410.Color = "Nasty";
          

            Ram rammer = new Ram();
            rammer.Color = "Church pew Gold";
            

            fxs.Drive();
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
            rammer.Stop();
        }
    }
}