using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);//Vai de 1 a 15, pois o 16 não entra, funcionando igual a indice
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;//Armazena a cor original do terminal
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Número encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior; //Volta a cor normal. Se não fizer, toda saida sairá em verde

                } else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente");
                    Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);

                }else
                {
                    Console.WriteLine("Maior... Tente novamente");
                    Console.WriteLine("Número de tentativas {0}", tentativasRestantes);
                }
            }
        }
    }
}
