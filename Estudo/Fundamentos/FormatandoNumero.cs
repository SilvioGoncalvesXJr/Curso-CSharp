using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));//Irá converter e mostrar com apenas 1 casa decimal
            Console.WriteLine(valor.ToString("C"));//Irá pegar e mostrar na moeda setada no sistema da maquina
            Console.WriteLine(valor.ToString("P"));//Irá multiplicar por 100 e mostrará a porcentagem
            Console.WriteLine(valor.ToString("#.##"));//Mostrará duas casas decimais. Poderia usar só o F2 no lugar

            CultureInfo cultura = new CultureInfo("pt-BR");//Pega as configurações setadas do Brasil
            Console.WriteLine(valor.ToString("C0", cultura));//moeda vazia do país cultura
            CultureInfo cultura2 = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2",cultura2));

            int inteiro = 256;
            //Se quiser adicionar zeros antes do número, basta colocar 'D' e o total de casas
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
