using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_PR1_Practica1
{
    public class SolarSystem : AEnergySystem
    {
        private double SunHours { get; set; }

        public override void ParameterConfigure()
        {
            while (true)
            {
                try
                {
                    SunHours = ValidateInput("Introdueix les hores de Sol disponibles (>1): ");
                    if (SunHours <= 1) throw new Exception("Les hores de Sol han de ser superiors a 1.");
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
            return SunHours * 1.5;
        }
    }


}

