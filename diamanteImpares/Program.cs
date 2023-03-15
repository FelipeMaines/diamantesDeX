using System.Runtime.Serialization.Formatters;

namespace diamanteImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a altura da pirâmide: ");
            int altura = int.Parse(Console.ReadLine());
            int espaco = altura - 1;
            int xis = 1;

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < espaco; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < xis; k++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();

                if (i < altura / 2)
                {
                    espaco--;
                    xis += 2;
                }
                else
                {
                    espaco++;
                    xis -= 2;
                }
            }
        }
    }   
}
