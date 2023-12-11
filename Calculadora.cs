using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos
{
    public class Calculadora
    {
      
        public static Double Somar(double a, double b){
            return a + b;
        }

        public static Double Subtrair(double a, double b){
            return a - b;
        }

        public static Double Multiplicar(double a, double b){
            return a * b;
        }

        public static Double Dividir(double a, double b){
            return a / b;
        }

        public static Double Potencia(double a, double b){
            return Math.Pow(a, b);
        }

    }
}