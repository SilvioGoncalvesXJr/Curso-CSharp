using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World").Replace("World", "Mundo");
            //O C# permite realizar varios comandos em mesma linha, através da notação ponto
            Console.WriteLine(saudacao);

            Console.WriteLine("Tamanho".Length);

            string valorImportante = null;

            Console.WriteLine(valorImportante?.Length);
            //Essa ? faz com que o comando da notação ponto, no caso o lenght, só seja acionado
            //caso a variavel esteja ok. Se estiver vazio, como no caso, irá retornar apenas o vazio
            //Se não tivesse o ?, daria um erro, por não dar certo em variável nula/vazia
        }
    }
}
