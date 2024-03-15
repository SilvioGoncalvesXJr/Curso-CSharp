using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);
            //Exemplo de conversão implícita. Pode ser feita quando não se perde informação

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);
            //Aqui como perde informação, precisou-se usar a conversão explicita, com o (int) nota
            //Sem  tentasse conversão implicita daria erro

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade Inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.WriteLine("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            //Esse TryParse é usado para caso o usuário colocar um valor que daria erro não travar o sistema
            //Vai apenas anexar o valor '0' se não conseguir converter
            Console.WriteLine("Resultado 1: {0}", numero1);

            //Otimizando o código:
            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}
