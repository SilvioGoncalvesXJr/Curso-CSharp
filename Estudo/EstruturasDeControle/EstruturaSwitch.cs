using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendimento com uma nota entre 1 a 5:");
            int.TryParse(Console.ReadLine(), out int nota);
            /*No caso do if e else, ira ser avaliado algo se é verdadeiro ou falso, de acordo com a condição estabelecida.
             Aqui, no switch, não se encaixa nesse contexto, mas entrará no bloco de código se o parametro for exatamente igual ao setado,
            quase como um conceito de caixas mesmo*/
            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");
                    break;
                default:
                    Console.WriteLine("Nota Inválida");
                    break;
                    //Entrará no default quando o valor não for equivalente aos demais casos
                    //No C# é obrigatório aplicar o break, se não, dará erro
            }
        }
    }
}
