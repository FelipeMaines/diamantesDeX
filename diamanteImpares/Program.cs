
namespace diamanteImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int altura;
            do {

                Console.Write("Digite a altura da pirâmide (numero impar): ");
                altura = int.Parse(Console.ReadLine()); 

            } while(altura % 2 != 1);


            int espaco = (altura - 1) / 2;
            int xis = 1; //yx

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

                if (i < (altura - 1) / 2)
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
