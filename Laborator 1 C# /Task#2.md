# Cea Mai Mare Cifră și Numărul de Apariții

## Descriere
Acest program C# determină cea mai mare cifră care apare în scrierea unui număr natural și numărul de apariții al acesteia.

## Funcționalitate
- Citește un număr natural de la tastatură
- Identifică cea mai mare cifră din număr
- Numără de câte ori apare această cifră
- Afișează rezultatul

## Cum funcționează
1. Citește numărul ca șir de caractere
2. Calculează frecvența fiecărei cifre (0-9)
3. Găsește cifra maximă cu cele mai multe apariții
4. Afișează rezultatul


```
using System;

class Program
{
    static void Main()
    {
        string n = Console.ReadLine();
        
        int[] frecventa = new int[10];
        
        foreach (char c in n)
        {
            if (char.IsDigit(c))
            {
                int cifra = c - '0';
                frecventa[cifra]++;
            }
        }
        
        int cifraMaxima = 0;
        int aparitiiMaxime = 0;
        
        for (int i = 9; i >= 0; i--)
        {
            if (frecventa[i] > aparitiiMaxime)
            {
                cifraMaxima = i;
                aparitiiMaxime = frecventa[i];
            }
        }
        
        Console.WriteLine($"{cifraMaxima} apare de {aparitiiMaxime} ori");
    }
}
```
