using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_PR1_Practica1
{
    public class EolicSystem : AEnergySystem
    {
        private double WindSpeed { get; set; }

        public override void ParameterConfigure()
        {
            while (true)
            {
                try
                {
                    WindSpeed = ValidateInput("Introdueix la velocitat del vent (mínim 5 m/s): ");
                    if (WindSpeed < 5) throw new Exception("La velocitat del vent ha de ser superior a 5 m/s.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            }
        }
        public override double EnergyCalculate()
        {
            return Math.Pow(WindSpeed, 3) * 0.2;
        }
    }
}
