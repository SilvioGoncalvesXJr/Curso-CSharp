using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Área da circunferência
            double raio = 4.5;
            const double PI = 3.14;//const quer dizer que a variável não pode ser alterada
            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine($"A área é {area}");

            //Tipos internos

            bool estaCHovendo = true;
            Console.WriteLine($" Está chovendo? {estaCHovendo}");

            byte idade = 45;
            Console.WriteLine($"A idade é {idade}");
            //byte só aceita valores positivos

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine($"O saldo de gols é {saldoDeGols}");//pega os valores negativos tbm. Vai imprimir o valor mínimo capaz de armazenar

            short salario = short.MaxValue;
            Console.WriteLine($"O salário é {salario}");

            int menorValorInt = int.MinValue;//Mais usado dos inteiros
            Console.WriteLine($"Menor valor para int {menorValorInt}");

            uint populacaoBrasileira = 207_600_000;//quando usamos o uint, é o int mas sem pegar os negativos, o int normal pega ambos
            Console.WriteLine($"População Brasileira {populacaoBrasileira}");

            long menorValorLong = long.MinValue;
            Console.WriteLine($"Menor valor de long é {menorValorLong}");

            ulong populacaoMundial = 7_600_000_000; //ulong não pega os valores negatiovs, com sinal
            Console.WriteLine($"A população mundial é {populacaoMundial}");

            float precoComputador = 1299.99f;//doble é o dobro do float e quando quiser usar double, precisa colocar o f no final    
            Console.WriteLine($"O preço do PC é {precoComputador}");

            double valorDeMercadoDaApple = 1_000_000_000_000.00;//Mais usado nos reais
            Console.WriteLine($"Valor de Mercado é {valorDeMercadoDaApple}");

            decimal distanciaEntreAsEstrelas =decimal.MaxValue;//Armazena valores astronomicos
            Console.WriteLine($"Capacidade máxima do decimal é: {distanciaEntreAsEstrelas}");

            char l = 'b';
            Console.WriteLine($"Letra {l}");

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto); 
        }   
    }
}
