using System;
using System.Collections.Generic;
namespace _4_Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do Curso A:");
            for (int i=0; i < x; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                A.Add(valor);
            }

            Console.Write("O curso B possui quantos alunos? ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do Curso B:");
            for (int i = 0; i < x; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                B.Add(valor);
            }

            Console.Write("O curso C possui quantos alunos? ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do Curso C:");
            for (int i = 0; i < x; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                C.Add(valor);
            }


            A.UnionWith(B);
            A.UnionWith(C);
            int contador = 0;
            foreach(int v in A)
            {
                contador++;
            }
            Console.WriteLine("Total de alunos: " + contador);
        }
    }
}
