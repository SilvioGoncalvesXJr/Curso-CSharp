﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;//&& = E
            Console.WriteLine("Comprou a Tv de 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;// || = ou
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // ^= xor
            Console.WriteLine("Comprou a Tv de 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);// ! = negação
        }
    }
}
