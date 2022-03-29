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

            double imc = peso / (altura*altura);

            Console.WriteLine("Nome: " + nome + "Peso: " + peso + "Altura: " + altura +  "IMC: " + imc);
        }
    }
}
