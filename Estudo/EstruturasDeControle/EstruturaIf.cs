using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if(entrada == "S" || entrada == "s")
            //    bomComportamento = true;
            //ou
            //bomComportamento = entrada == "S" || entrada == "s";
            //ou
            bomComportamento = entrada.ToLower() == "s";


            if(nota >= 9.0 && bomComportamento)//Se me enganar e colocar um';' aqui depois do (), isso fará com que a condicional não seja acessada, criando um bug, permitindo que tudo entre no if
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
