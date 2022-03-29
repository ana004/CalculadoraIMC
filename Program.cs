// See https://aka.ms/new-console-template for more information
using System;

namespace EstudoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua altura em metros? ");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual é o seu peso em Kg? ");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = Math.Round(peso / (altura*altura), 2);

            Console.WriteLine("Nome: " + nome + " " + "Peso: " + peso + " " + "Altura: " + altura + " " +  "IMC: " + imc);

            if (imc < 17)
                Console.WriteLine("Muito abaixo do peso");
            else if (imc >= 17 && imc <= 18.49)
                Console.WriteLine("Abaixo do peso");
            else if (imc >= 18.50 && imc <= 24.99)
                Console.WriteLine("Peso normal");
            else if (imc >= 25 && imc <= 29.99)
                Console.WriteLine("Acima do peso");
            else if (imc >= 30 && imc <= 34.99)
                Console.WriteLine("Obesidade I");
            else if (imc >= 35 && imc <= 39.99)
                Console.WriteLine("Obesidade II (severa)");
            else if (imc >= 40)
                Console.WriteLine("Obesidade III (mórbida)");
        }
    }
}
