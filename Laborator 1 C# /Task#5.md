# Generator Tabel Înmulțire

## Descriere
Acest program C# generează și afișează tabelul înmulțirii pentru un număr dat de la 1 la 10 folosind o buclă for.

## Funcționalitate
- Citește un număr de la tastatură
- Generează tabelul înmulțirii de la 1 la 10
- Afișează fiecare operație de înmulțire pe rând

## Algoritm
- Folosește o buclă for de la 1 la 10
- Calculează produsul numărului cu fiecare iterator
- Afișează rezultatul sub forma: n x i = rezultat

### Codul Sursa

```
using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Tabelul inmultirii pentru {n}:");
        
        for (int i = 1; i <= 10; i++)
        {
            int rezultat = n * i;
            Console.WriteLine($"{n} x {i} = {rezultat}");
        }
    }
}
```
