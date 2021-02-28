using System;
using EquazioniLibrary;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il numero accanto di cosa vuoi eseguire:\n1 verifica se è determinata, \n2 se è impossibile, \n3 se è di secondo grado, \n4 se vuoi calcolare il delta, \n5 se vuoi il risultato di un'equazione di secondo grado, \n6 se vuoi il risultato di un'equazione di primo grado \n");
            string str = Console.ReadLine();

            switch (str)
            {
                case "1":
                    Console.Write("Inserisci il valore di a: ");
                    int a = int.Parse(Console.ReadLine());
                    bool b = Equazioni.IsDetermined(a);
                    if (b)
                        Console.WriteLine("l'equazione è determinata");
                    else
                        Console.WriteLine("l'equazione non è determinata");
                    break;

                case "2":
                    Console.Write("Inserisci il valore di a: ");
                    int a1 = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci il valore di b: ");
                    int b1 = int.Parse(Console.ReadLine());
                    bool b2 = Equazioni.IsInconsisted(a1, b1);
                    if (b2)
                        Console.WriteLine("l'equazione è impossibile");
                    else
                        Console.WriteLine("l'equazione non è impossibile");
                    break;

                case "3":
                    Console.Write("Inserisci il valore di a: ");
                    int a2 = int.Parse(Console.ReadLine());
                    bool b3 = Equazioni.IsDegree2(a2);
                    if (b3)
                        Console.WriteLine("è di secondo grado");
                    else
                        Console.WriteLine("non è di secondo grado");
                    break;

                case "4":
                    Console.Write("Inserisci il valore di a: ");
                    int a3 = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci il valore di b: ");
                    int b4 = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci il valore di c: ");
                    int c = int.Parse(Console.ReadLine());
                    double b5 = Equazioni.Delta(a3,b4,c);
                    Console.WriteLine($"Il delta è: {b5} ");
                    break;
                case "5":
                    Console.Write("Inserisci il valore di a: ");
                    int a4 = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci il valore di b: ");
                    int b6 = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci il valore di c: ");
                    int c1 = int.Parse(Console.ReadLine());
                    string s = Equazioni.Equazione(a4, b6, c1);
                    Console.WriteLine(s);
                    break;

                case "6":
                    Console.Write("Inserisci il valore di a: ");
                    double a5 = int.Parse(Console.ReadLine());
                    Console.Write("Inserisci il valore di b: ");
                    double b7 = int.Parse(Console.ReadLine());
                    string s1 = Equazioni.EquationDegree1(a5, b7);
                    Console.WriteLine(s1);
                    break;


                default:
                    Console.Write("valore inserito non valido");
                    break;

            }
        }
    }
}
