// Projeto de Avaliação (Revisado) - Variante 3: Cálculo de média de três notas
// Este programa deve solicitar o nome do estudante e três notas, calcular e exibir a média.
// Vários erros foram introduzidos na declaração dos tipos, controle de loop e operações aritméticas.


using System;

namespace Cp01 //adição do namespace
{
    internal class Program //add internal 
    {
        static void Main(string[] args) //add String Args
        {
            Console.WriteLine("Digite o nome do estudante:");

            String nome = Console.ReadLine(); //mudança de int para string 
            double soma = 0;

            for (int i = 1; i <= 3; i++)//troca do 0 para 1
            {
                Console.WriteLine("Digite a nota " + i + ":");
                double nota = double.Parse(Console.ReadLine()); // mudança string para double, mais add parseInt

                soma = soma + nota;
            }

            double media = soma / 3; //troca do 2 para 3
            Console.WriteLine("A média do estudante " + nome + " é " + media);
        }
    }
}