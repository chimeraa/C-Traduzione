using System;

namespace Esercizi
{
    class Program
    {
        // Dichiarazione del metodo ausiliario
        static void StampaCopie(string s, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(s);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Scegli l'esercizio da eseguire (1-7): ");
            int scelta = Convert.ToInt32(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    // Esercizio 1
                    int somma = 0, conta = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        Console.Write("Inserisci un numero intero: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (num % 7 == 0)
                        {
                            somma += num;
                            conta++;
                        }
                    }
                    Console.WriteLine("La media dei numeri multipli di 7 inseriti è {0}", (double)somma / conta);
                    break;
                case 2:
                    // Esercizio 2
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("Inserisci un carattere: ");
                        char c = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Hai inserito il carattere {0}", c);
                    }
                    break;
                case 3:
                    // Esercizio 3
                    Console.Write("Inserisci una stringa: ");
                    string s = Console.ReadLine();
                    for (int i = s.Length - 1; i >= 0; i--)
                    {
                        Console.Write(s[i]);
                    }
                    Console.WriteLine();
                    break;
                case 4:
                    // Esercizio 4
                    Console.Write("Inserisci una stringa: ");
                    s = Console.ReadLine();
                    foreach (char c in s)
                    {
                        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                        {
                            Console.Write(c);
                        }
                    }
                    Console.WriteLine();
                    break;
                case 5:
                    // Esercizio 5
                    int sommaa = 0;
                    while (true)
                    {
                        Console.Write("Inserisci una stringa (vuota per terminare): ");
                        string so = Console.ReadLine();
                        if (so == "")
                        {
                            break;
                        }
                        if (Char.IsUpper(so[0]))
                        {
                            sommaa += so.Length;
                        }
                    }
                   
Console.WriteLine("La somma delle lunghezze delle stringhe che iniziano con una lettera maiuscola è {0}", sommaa);
                    break;
                case 6:
                    // Esercizio 6
                    Console.Write("Inserisci una stringa: ");
                    s = Console.ReadLine();
                    Console.Write("Inserisci un numero intero positivo: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n >= 0)
                    {
                        StampaCopie(s, n);
                    }
                    else
                    {
                        Console.WriteLine("ERRORE: numero negativo");
                    }
                    break;
                case 7:
                    // Esercizio 7
                    int[] numeri = { 1,2,3,4,5,6,7};
                    int sommaPari = 0;
                    int sommaDispari = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        if (i % 2 == 0)
                        {
                            sommaPari += numeri[i];
                        }
                        else
                        {
                            sommaDispari += numeri[i];
                        }
                    }
                    if (sommaPari == sommaDispari)
                    {
                        Console.WriteLine("Pari e dispari uguali");
                    }
                    else
                    {
                        Console.WriteLine("Pari e dispari diversi");
                    }
                    break;
            }
        }
    }
}
