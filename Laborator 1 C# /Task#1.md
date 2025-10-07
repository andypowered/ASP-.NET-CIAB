# Analizor de Numere - C# Console Application

## Descriere
Acest proiect este o aplicație consolă în C# care analizează numerele dintr-un interval [0, N] și identifică patru categorii de numere, calculând suma și produsul pentru fiecare categorie.

## Funcționalități

### 🔍 Categorii de Numere Identificate

1. **Numere Pare**
   - Numere divizibile cu 2
   - Exemplu: 0, 2, 4, 6, 8...

2. **Numere Impare**
   - Numere care nu sunt divizibile cu 2
   - Exemplu: 1, 3, 5, 7, 9...

3. **Numere Perfecte**
   - Numere egale cu suma divizorilor proprii
   - Exemplu: 6 = 1 + 2 + 3

4. **Numere Prime**
   - Numere naturale mai mari decât 1 cu exact doi divizori
   - Exemplu: 2, 3, 5, 7, 11...

### Cerințe Sistem
- .NET Framework sau .NET Core
- Visual Studio sau orice editor de text cu compilator C#

### Codul sursa 
```
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti valoarea lui N: ");
        int N = int.Parse(Console.ReadLine());

        if (N < 0)
        {
            Console.WriteLine("N trebuie sa fie un număr pozitiv!");
            return;
        }

        List<int> numerePare = new List<int>();
        List<int> numereImpare = new List<int>();
        List<int> numerePerfecte = new List<int>();
        List<int> numerePrime = new List<int>();

        for (int i = 0; i <= N; i++)
        {
            if (i % 2 == 0)
            {
                numerePare.Add(i);
            }
            else
            {
                numereImpare.Add(i);
            }

            if (EsteNumarPerfect(i))
            {
                numerePerfecte.Add(i);
            }

            if (EsteNumarPrim(i))
            {
                numerePrime.Add(i);
            }
        }

        AfiseazaRezultate("Pare", numerePare);
        AfiseazaRezultate("Impare", numereImpare);
        AfiseazaRezultate("Perfecte", numerePerfecte);
        AfiseazaRezultate("Prime", numerePrime);
    }

    static bool EsteNumarPerfect(int numar)
    {
        if (numar < 2) return false; 

        int sumaDivizori = 0;
        for (int i = 1; i <= numar / 2; i++)
        {
            if (numar % i == 0)
            {
                sumaDivizori += i;
            }
        }
        return sumaDivizori == numar;
    }

    static bool EsteNumarPrim(int numar)
    {
        if (numar < 2) return false; 

        if (numar == 2) return true; 

        if (numar % 2 == 0) return false; 

        for (int i = 3; i * i <= numar; i += 2)
        {
            if (numar % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void AfiseazaRezultate(string tip, List<int> numere)
    {
        Console.WriteLine($"\n--- Numere {tip} în intervalul [0, {(numere.Count > 0 ? numere[numere.Count - 1] : 0)}] ---");

        if (numere.Count == 0)
        {
            Console.WriteLine("Nu există numere de acest tip în interval.");
            return;
        }

        Console.Write("Numere: ");
        foreach (int numar in numere)
        {
            Console.Write(numar + " ");
        }

        long suma = 0;
        foreach (int numar in numere)
        {
            suma += numar;
        }
        Console.WriteLine($"\nSuma: {suma}");

        long produs = 1;
        bool existaNumereNonZero = false;

        foreach (int numar in numere)
        {
            if (numar != 0)
            {
                produs *= numar;
                existaNumereNonZero = true;
            }
        }

        if (!existaNumereNonZero)
        {
            produs = 0;
        }

        Console.WriteLine($"Produs: {produs}");
        Console.WriteLine($"Total numere: {numere.Count}");
    }
}

```

