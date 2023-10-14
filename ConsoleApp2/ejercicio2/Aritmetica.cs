using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp2.ejercicio2
{
    internal class Aritmetica
    {
        private double num1;
        private double num2;
        private double num3;
        private double num4;

        public Aritmetica (double num1, double num2, double num3, double num4)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
            this.num4 = num4;
        }

        public double Getsuma()
        {
            return num1 + num2;
        }

        public double Producto()
        {
            return num3 * num4;
        }
    }
}
