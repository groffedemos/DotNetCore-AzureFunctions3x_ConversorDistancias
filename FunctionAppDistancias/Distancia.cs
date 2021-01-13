using System;

namespace FunctionAppDistancias
{
    public class Distancia
    {
        public DateTime DataProcessamento { get; }
        public double Milhas { get; }
        public double Km { get; }

        public Distancia(double milhas)
        {
            Milhas = milhas;
            Km = Math.Round(Convert.ToDouble(milhas) * 1.609, 3);
        }
    }
}
