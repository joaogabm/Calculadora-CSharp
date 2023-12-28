using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCalculadora.models
{
    public class Calculadora
    {
        public void Adição() {
            Console.Write("Digite o primeiro número: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double soma = x + y;
            Console.WriteLine($"{x} + {y} = {soma}");
        }

        public void Subtração() {
            Console.Write("Digite o primeiro número: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double subtração = x - y;
            Console.WriteLine($"{x} - {y} = {subtração}");
        }

        public void Multiplicação() {
            Console.Write("Digite o primeiro número: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double multiplicação = x * y;
            Console.WriteLine($"{x} X {y} = {multiplicação}");
        }

        public void Divisão() {
            Console.Write("Digite o primeiro número: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double divisão = x / y;
            Console.WriteLine($"{x} / {y} = {divisão}");
        }

        public void Potência() {
            Console.Write("Digite o número base: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o número expoente: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double potência = Math.Pow(x,y);
            Console.WriteLine($"{x}^{y} = {potência}");
        }

        public void RaizQuadrada () {
            Console.Write("Digite o número radicando: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double raizquadrada = Math.Sqrt(x);
            Console.WriteLine($"√{x} = {Math.Round(raizquadrada, 3)}");
        }
    }
}