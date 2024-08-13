using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Moto
    {
        public string Marca {  get; private set; }
        public int Modelo {  get; private set; }
        public double ValorFabricacion { get; private set; }

        public Moto(string marca, int modelo, double valorFabricacion) 
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorFabricacion;
        }
        public double CalcularDepreciacionLineal(int añoACalcular, int vidaUtil)
        {
            double valact;
            int añosuso = añoACalcular - Modelo;
            valact = ValorFabricacion - (ValorFabricacion*(añosuso/vidaUtil));
            return valact;
        }
        public double CalcularDepreciacionAnual(int añoACalcular, double tasaDepreciacion)
        {
            double valact;
            int añosuso = añoACalcular - Modelo;
            valact = ValorFabricacion * Math.Pow((1 - tasaDepreciacion), añosuso);
            return valact;
        }
    }
}
