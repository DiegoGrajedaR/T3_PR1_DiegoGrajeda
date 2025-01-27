using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_PR1_Practica1
{
    public class HydroElectricSystem : AEnergySystem
    {
        private double WaterCabal { get; set; }

        public override void ParameterConfigure()
        {
            while (true)
            {
                try
                {
                    WaterCabal = ValidateInput("Introdueix el cabal de l'aigua (mínim 20 m^3)");
                    if (WaterCabal < 20) throw new Exception("El cabal de l'aigua ha de ser superior a 20 m^3");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                }
            }
        }
        public override double EnergyCalculate()
        {
            return WaterCabal * 9.8 * 0.8;
        }
    }
}
