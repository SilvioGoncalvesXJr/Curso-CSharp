﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Informe a nota do aluno: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota > 9)
            {
                Console.WriteLine("Quadro de honra");
            } else if (nota >= 7)
            {
                Console.WriteLine("Aprovado");
            } else if (nota >= 5)
            {
                Console.WriteLine("Recuperação");
            } else
            {
                Console.WriteLine("Te vejo na proxima...");
            }
            
        }
    }
}
