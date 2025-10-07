# Calculator Expresie Matematică

## Descriere
Acest program C# calculează valoarea unei expresii matematice definite pe ramuri în funcție de valoarea variabilei `c`.


## Funcționalitate
- Citește trei numere reale: a, b, c
- Calculează expresia conform condițiilor
- Gestionează cazul de împărțire la zero
- Afișează rezultatul cu 4 zecimale

## Condiții
- **c > 0**: e = √(a + b)
- **c = 0**: e = a * b  
- **c < 0**: e = 1/(a - b)

## Validare
- Verifică împărțirea la zero pentru cazul c < 0
- Afișează mesaj de eroare dacă a = b și c < 0

### Codul Sursa
```
using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti a: ");
        double a = double.Parse(Console.ReadLine());
        
        Console.Write("Introduceti b: ");
        double b = double.Parse(Console.ReadLine());
        
        Console.Write("Introduceti c: ");
        double c = double.Parse(Console.ReadLine());
        
        double e;
        
        if (c > 0)
        {
            e = Math.Sqrt(a + b);
        }
        else if (c == 0)
        {
            e = a * b;
        }
        else
        {
            if (a - b == 0)
            {
                Console.WriteLine("Eroare: Impartire la zero!");
                return;
            }
            e = 1.0 / (a - b);
        }
        
        Console.WriteLine($"Valoarea expresiei e este: {e:F4}");
    }
}
```
