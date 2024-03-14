using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual o seu nome? ");

            string nome = Console.ReadLine();

            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            //Normalmente, o input vem como string, e para converter para int usar o Parse é uma das possibilidades

            Console.Write("Qual o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //No caso do double, o input irá seguir a configuração da maquina e para pegar os decimais
            //precisa colocar a virgula ao invés de ponto. Para poder usar o ponto também, se associará
            //através do system globalization e o comando cultureinfo

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
