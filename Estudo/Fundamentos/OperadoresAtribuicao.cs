using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10;//num1 = num1 + 10;
            num1 -= 3;//num1 = num1 - 3;
            num1 *= 5;//num1 = num1 * 5;
            num1 /= 2;// num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            Console.WriteLine($"{a} {b}");

            a++;// a = a + 1;
            b--;//b = b -1;

            Console.WriteLine($"{a} {b}");
            //Aqui, a e b foram atribuidas por valor. Mudando 1 não altera a outra

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";
            Console.WriteLine(c.nome);
            //Aqui, não foi atribuido por valor, mas por referencia. Muda 1 altera o outro
        }
    }
}
