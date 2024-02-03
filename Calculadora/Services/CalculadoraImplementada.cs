using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Services.Calculadora
{
    public class CalculadoraImplementada
    {
        public int Somar(int num1, int num2){
            return num1 + num2;
        }
        public int Subtrair(int num1, int num2){
            return num1 - num2;
        }
        public int Multiplicar(int num1, int num2){
            return num1 * num2;
        }
        public int Dividir(int num1, int num2){
            return num1 / num2;
        }
    }
}