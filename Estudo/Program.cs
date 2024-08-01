﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos" , Interpolacao.Executar},
                {"Notação Ponto - Fundamentos" , NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos" , LendoDados.Executar},
                {"Formatando Números - Fundamentos" , FormatandoNumero.Executar},
                {"Conversões de Tipos - Fundamentos" , Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos" , OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos" , OperadorRelacional.Executar},
                {"Operadores Lógicos - Fundamentos" , OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos" , OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos" , OperadoresUnarios.Executar},
                {"Operadores Ternário - Fundamentos" , OperadorTernario.Executar},
                
                //Estruturas de Controle
                {"Estrutura If - Estruturas de Controle" , EstruturaIf.Executar},
                {"Estrutura IfElse - Estruturas de Controle" , EstruturaIfElse.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}