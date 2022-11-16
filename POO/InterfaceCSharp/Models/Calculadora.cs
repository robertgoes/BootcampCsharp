using InterfaceCsharp.Interfaces;

namespace InterfaceCsharp.Models
{
    public class Calculadora : ICalculadora
    {
        public double Somar(double num1, double num2)
        {
            return num1 + num2;
        }
        
        public double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }
        
        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}