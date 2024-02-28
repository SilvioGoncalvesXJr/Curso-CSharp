using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{   
    internal class Comentarios
    {
        /// <summary>
        /// XML Comments
        /// </summary>
        public static void Executar()
        {
            //Pode comentar através de barras duplas para 1 linha ou usar 
            /*Para 
             * Mais de 1 linha
             */
            Console.WriteLine("Código claro é sempre melhor");
            ///Que usa tags e outras funções para facilitar documentação, apenas usando 3 barras///, como entre calsse e executar
            Console.WriteLine("Além disso, tem o XML Comments");
        }
    }
}
