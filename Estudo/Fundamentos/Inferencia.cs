using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Inferencia
    {
        public static void Executar()
        {
            /*
             C# é uma linguagem fortemente tipada, pela definição prévia do tipo, mas ela também permite
            quer ao não realizar essa declaração, acaba delimitando o seu tipo automaticamente através do
            conteúdo anexado a variável. Isso só é possível nos casos em que se é atribuído valor,
            nos demais dará erro
             */
            var nome = "Silvio";
            //Aqui, nome será um string pela associação feita com o valor "Silvio" a ela
            Console.WriteLine(nome);
        }
    }
}
