using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_for_vetor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            string[] nomes = new string[25];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite os nomes: ");
                nomes[i] = Console.ReadLine();
            }
            Console.Clear();

            Console.WriteLine("Pessoas cadastradas: ");

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nomes: " + nomes[i]);
            }
        }
    }
}
