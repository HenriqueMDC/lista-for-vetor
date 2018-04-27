using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_for_vetor
{
    class Exercicio02
    {
        public Exercicio02()
        {
            int[] idades = new int[7];

            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine("Digite as idades: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("Idades cadastradas: ");

            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine("Idades: " + idades[i]);
            }
        }
    }
}
