using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_PR1_Practica1
{
    public abstract class AEnergySystem : IEnergyCalculation
    {
        public DateTime SimulationDate { get; set; }

        public abstract void ParameterConfigure();
        public abstract double EnergyCalculate();

        public void SimulationSign()
        {
            SimulationDate = DateTime.Now;
        }

        public double ValidateInput(string text)
        {
            double value;
            while (true)
            {
                try
                {
                    Console.WriteLine(text);
                    value = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Introdueix un número vàlid.");
                }
            }
            return value;
        }


    }
}
