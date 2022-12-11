using System;

namespace lab3ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 5
                Arpsod adoră două lucruri: matematica și clătitele bunicii sale. Într-o zi, aceasta s-a apucat să
                prepare clătite. Arpsod mănâncă toate clătitele începând de la a N-a clătită preparată, până
                la a M-a clătită preparată (inclusiv N și M). Pentru că el vrea să mănânce clătite cu diferite
                umpluturi și-a făcut următoarea regulă:
                 Dacă numărul de ordine al clătitei este prim atunci aceasta va fi cu ciocolată.
                 Dacă numărul de ordine este pătrat perfect sau cub perfect aceasta va fi cu gem.
                 Dacă suma divizorilor numărului este egală cu însuși numărul de ordine atunci aceasta va fi cu
                înghețată. (se iau în considerare toți divizorii în afară de numărul în sine, inclusiv 1).
                 Dacă niciuna dintre condițiile de mai sus nu este îndeplinită, pentru cele cu numărul de ordine
                par, clătita va fi cu zahar, iar pentru numărul de ordine impar, clătita va fi simplă.”
                • Cerința
                 Cunoscându-se N și M, numere naturale, să se determine câte clătite a mâncat Arpsod în total și
                numărul de clătite din fiecare tip. A
                • Indicii
                1. iteratorul unui for nu incepe neaparat de la 1 ☺
                2. folositi functii: extrageti operatiile matematice complicate asupra intregilor in functii. Veti
                simplifica astfel partea de logica.
             */
            static bool IsPrime(int n)
            {
                if (n <= 1)
                {
                    return false;
                }
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            static bool IsPerfectSquare(int n)
            {
                //daca restul impartirii radacinii patrate a lui n la 1 este 0, este patrat perfect
                if (Math.Sqrt(n) % 1 == 0)
                {
                    return true;
                }
                return false;
            }

            static bool IsPerfectCube(int n)
            {
                for (int i = 2; i <= n; i++)
                {
                    if (Math.Pow(i, 3) == n)
                    {
                        return true;
                    }
                }
                return false;
            }

            static int GetSumOfDividers(int n)
            {
                int sum = 0;
                for (int i = 1;i<=n; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }

            static bool IsEven(int n)
            {
                if (n % 2 == 0)
                {
                    return true;
                }
                return false;
            }



            Console.WriteLine("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("M = ");
            int m = int.Parse(Console.ReadLine());


            int choco = 0;
            int jam = 0;
            int iceCream = 0;
            int sugar = 0;
            int simple = 0;

            for (int i = n; i <= m; i++)
            {
                if (IsPrime(i))
                {
                    choco++;
                } else if (IsPerfectSquare(i) || IsPerfectCube(i))
                {
                    jam++;
                } else if (GetSumOfDividers(i) - i == n)
                {
                    iceCream++;
                } else
                {
                    if(IsEven(i))
                    {
                        sugar++;
                    } else
                    {
                        simple++;
                    }
                }
            }
            //să se determine câte clătite a mâncat Arpsod în total și
            //numărul de clătite din fiecare tip. A
            Console.WriteLine($"Arpsod a mancat in total {choco + jam + iceCream + sugar + simple} clatite, din care:");
            Console.WriteLine($"{choco} cu ciocolata");
            Console.WriteLine($"{jam} cu gem");
            Console.WriteLine($"{iceCream} cu inghetata");
            Console.WriteLine($"{sugar} cu zahar");
            Console.WriteLine($"{simple} simple");











     



        }
    }
}
