using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introdu numarul natural:");
        string numar = Console.ReadLine();

        char cifraMax = numar[0];
        int maxLungime = 1;

        char cifraCurenta = numar[0];
        int lungimeCurenta = 1;
        int i = 1; 
        while (i < numar.Length)
        {
            if (numar[i] == cifraCurenta)
            {
                lungimeCurenta++; 
            }
            else
            {
                while (lungimeCurenta > maxLungime)
                {
                    maxLungime = lungimeCurenta;
                    cifraMax = cifraCurenta;
                }

                cifraCurenta = numar[i];
                lungimeCurenta = 1;
            }
            i++;
        }

        if (lungimeCurenta > maxLungime)
        {
            maxLungime = lungimeCurenta;
            cifraMax = cifraCurenta;
        }

        Console.WriteLine($"Cifra care apare consecutiv de cele mai multe ori: {cifraMax}");
        Console.WriteLine($"Lungimea secventei: {maxLungime}");
    }
}
