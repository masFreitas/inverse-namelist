using System;

namespace LeiaEListeNomes__Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Faça um programa que leia 5 nomes e logo após, escreva os nomes na ordem inversa ao que foi digitada.
            string[] nomes = new string[10];
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Escreva um nome:");
                nomes[i] = Console.ReadLine();
            }
            
            for (i = 5; i >= 0; i--)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
