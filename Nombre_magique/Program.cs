using System;

namespace Nombre_magique
{
    class Program
    {

        // DemanderNombre
        static int DemanderNombre(int min, int max)
        {
            int nb = min - 1;

            while ((nb > max) || (nb < min))
            {
                Console.Write("Veuillez entre un nombre (entre " + min + " et " + max + ") : ");
                string nbStr = Console.ReadLine();

                try
                {
                    nb = int.Parse(nbStr);
                    if (nb == 0)
                    {
                        Console.WriteLine("ERREUR : Veuillez entrer un nombre supérieur à 0.");
                    }
                    else if ((nb > max) || (nb < min))
                    {
                        Console.WriteLine("ERREUR : Le nombre doit être entre " + min + "et" + max);
                    }
                }
                catch
                {
                    Console.WriteLine("ERREUR : Veuillez entrer un nombre valide");
                }
            }
            return nb;
        }

        static void Main(string[] args)
        {

            Random rand = new Random();
            const int NOMBRE_MIN = 0;
            const int NOMBRE_MAX = 10;
            int nbMagique = rand.Next(NOMBRE_MIN, (NOMBRE_MAX+1));

            int nbVies = 4;
            for (; nbVies > 0; nbVies--)
            {
                Console.WriteLine("\nNombre de vie : " + (nbVies));
                int nbInput = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);

                if (nbInput < nbMagique)
                {
                    Console.WriteLine("Le nombre est plus grand"); 
                }
                else if (nbInput > nbMagique)
                {
                    Console.WriteLine("Le nombre est plus petit");
                }
                else
                {
                    // cas ou le nbMagique à été trouvé
                    Console.WriteLine("\nBravo ! vous avez trouvé le nombre");
                    break;
                }
            }
             
            if (nbVies == 0)
            {
                Console.WriteLine("\nVous avez perdu. Le nombre magique était : " + nbMagique);
            }

        }
    }
}