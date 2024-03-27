using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 7;
            bool bomComportamento = true;
            string resultado = nota >= 7 && bomComportamento ? "Aprovado" : "Reprovado";
            ///Essa estrutura diz que se a condição for verdadeira, setar a primeira string, se falsa, a segunda
            ///Acaba sendo uma espécie de if else
            ///Um OBS importante. Os valores setados precisam ser do mesmo tipo da variável
            ///Não poderia ser um "Aprovado" e um 7 no segundo, por ex.
            Console.WriteLine(resultado);
        }
    }
}
