using System;

namespace set2_secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            int optiune;
            
            Console.WriteLine("1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare. \n");
            Console.WriteLine("2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. \n");
            Console.WriteLine("3. Calculati suma si produsul numerelor de la 1 la n. \n");
            Console.WriteLine("4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. \n");
            Console.WriteLine("5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. \n");
            Console.WriteLine("6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. \n");
            Console.WriteLine("7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.\n");
            Console.WriteLine("8. Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...\n");
            Console.WriteLine("9. Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. \n");
            Console.WriteLine("10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. \n");
            Console.WriteLine("11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. \n");
            Console.WriteLine("12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. \n");
            Console.WriteLine("13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. \n");
            Console.WriteLine("14. O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. \n");
            Console.WriteLine("15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. \n");
            Console.WriteLine("16. O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. \n");
            Console.WriteLine("17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. \n");
            
            Console.WriteLine("Alegeti una din problemele de mai sus: \n");
            
            optiune = int.Parse(Console.ReadLine());

            switch (optiune)
            {
                case 1:
                    P1();
                    break;
                case 2:
                    P2();
                    break;
                case 3:
                    P3();
                    break;
                case 4:
                    P4();
                    break;
                case 5:
                    P5();
                    break;
                case 6:
                    P6();
                    break;
                case 7:
                    P7();
                    break;
                case 8:
                    P8();
                    break;
                case 9:
                    P9();
                    break;
                case 10:
                    P10();
                    break;
                case 11:
                    P11();
                    break;
                case 12:
                    P12();
                    break;
                case 13:
                    P13();
                    break;
                case 14:
                    P14();
                    break;
                case 15:
                    P15();
                    break;
                case 16:
                    P16();
                    break;
                case 17:
                    P17();
                    break;
            }

        }

        /// <summary>
        /// Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.
        /// Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor.
        /// De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. 
        /// </summary>
        private static void P17()
        {
            int i,j,nr,k=0;
            bool ok = true;
            Console.WriteLine("introduceti sirul:");
            string linie = Console.ReadLine();
            char[] seps = { ' ' };
            string[] tokens = linie.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            
            for(i=0;i<tokens.Length;i++)
            {
                nr = int.Parse(tokens[i]);
                if (nr == 0)
                    k++;
                else if (nr == 1 && k == 0)
                    ok = false;
                else
                    k--;
                
            }
            if(ok && k==0)
                    Console.WriteLine(1);
                else
                    Console.WriteLine(0);
        }

        /// <summary>
        /// O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive
        /// (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 
        /// </summary>
        private static void P16()
        {
            
        }

        /// <summary>
        /// O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator.
        /// De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 
        /// </summary>
        private static void P15()
        {
           
        }

        /// <summary>
        /// O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive.
        /// Determinati daca o secventa de n numere este o secventa monotona rotita. 
        /// </summary>
        private static void P14()
        {
            
        }

        /// <summary>
        /// O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare 
        /// sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive 
        /// (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul).
        /// Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
        /// </summary>
        private static void P13()
        {
            
        }

        /// <summary>
        /// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. 
        /// Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. 
        /// De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
        /// </summary>
        private static void P12()
        {
            int n, nr, i, nrcuv=0;
            bool cuv=false;
            Console.WriteLine("Cate numere contine secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti cele {n} numere pe o singura linie, separate prin cate-un spatiu");
            string linie = Console.ReadLine();
            char[] seps = { ' ' };
            string[] tokens = linie.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            for(i=0;i<n;i++)
            {
                nr = int.Parse(tokens[i]);
                if (nr == 0)
                    cuv = false;
                else if (cuv==false)
                {
                    nrcuv++;
                    cuv = true;
                }
            }
            Console.WriteLine($"sunt {nrcuv} grupuri de numere consecutive diferite de zero");
        }

        /// <summary>
        /// Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
        /// </summary>
        private static void P11()
        {
            int n,nr, i, suma=0,inv;
            Console.WriteLine("Cate numere contine secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti cele {n} numere pe o singura linie, separate prin cate-un spatiu");
            string linie = Console.ReadLine();
            char[] seps = { ' ' };
            string[] tokens = linie.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            for (i=0;i<n;i++)
            {
                nr = int.Parse(tokens[i]);
                inv = 0;
                while (nr!=0)
                {
                    inv = inv * 10 + nr % 10;
                    nr /= 10;
                }
                suma += inv;
            }
            Console.WriteLine($"Suma secventei este {suma}");
        }

        /// <summary>
        /// Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.
        /// </summary>
        private static void P10()
        {
            int n, i,l=1,lmax=1,nr1,nr2;
            Console.WriteLine("Cate numere contine secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti cele {n} numere pe o singura linie, separate prin cate-un spatiu");
            string linie = Console.ReadLine();
            char[] seps = { ' ' };
            string[] tokens = linie.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            nr1 = int.Parse(tokens[0]);
            for(i=1;i<n;i++)
            {
                nr2 = int.Parse(tokens[i]);
                if (nr1 == nr2)
                {
                    l++;
                    if (l > lmax)
                        lmax = l;
                }
                else
                {
                    nr1 = nr2;
                    l = 1;
                }
            }
            Console.WriteLine($"numarul maxim de numere consecutive egale din secventa este {lmax}");
        }

        /// <summary>
        /// Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
        /// </summary>
        private static void P9()
        {
            int n,i,nr1,nr2;
            bool ok = true;
            Console.WriteLine("Cate numere contine secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti cele {n} numere pe o singura linie, separate prin cate-un spatiu");
            string linie = Console.ReadLine();
            char[] seps = { ' ' };
            string[] tokens = linie.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            nr1 = int.Parse(tokens[0]);
            nr2 = int.Parse(tokens[1]);
            if(nr1>nr2)
            {
                
                for (i = 3; i < n; i++)
                {
                    nr1 = nr2;
                    nr2 = int.Parse(tokens[i]);
                    if (nr2 > nr1)
                        ok = false;
                }
                if(ok==true)
                    Console.WriteLine("Secventa este monoton descrescatoare");
                else
                    Console.WriteLine("Secventa nu este monotona");
                    
            }
            else if(nr1<nr2)
            {
                for (i= 3;i< n;i++)
                {
                    nr1 = nr2;
                    nr2 = int.Parse(tokens[i]);
                    if (nr1 > nr2)
                        ok = false;
                }
                if(ok==true)
                    Console.WriteLine("Secventa este monoton crescatoare");
                else 
                    Console.WriteLine("Secventa nu este monotona");
            }
            
        }

        /// <summary>
        /// Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel:
        /// f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
        /// </summary>
        private static void P8()
        {
            int n,f1=0,f2=1,f3=-1,i;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            if(n==1)
                Console.WriteLine(f1);
            else if(n==2)
                Console.WriteLine(f2);
            else if(n>2)
            {
                for(i=3;i<=n;i++)
                {
                    f3 = f1 + f2;
                    f1 = f2;
                    f2 = f3;
                }
                Console.WriteLine(f3);
            }
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
        /// </summary>
        private static void P7()
        {
            int n, nr, minim, maxim, i;
            Console.WriteLine("Cate numere contine secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti cele {n} numere pe o singura linie, separate prin cate-un spatiu");
            string linie = Console.ReadLine();
            char[] seps = { ' ' };
            string[] tokens = linie.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            minim=maxim = int.Parse(tokens[0]);
            for (i = 1; i < n; i++)
            {
                nr = int.Parse(tokens[i]);
                if (nr > maxim)
                    maxim = nr;
                if (nr < minim)
                    minim = nr;
            }
            Console.WriteLine($"Minimul din secventa este {minim}, iar maximul este {maxim}");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
        /// </summary>
        private static void P6()
        {
            int n,i,nr1,nr2;
            bool ok = true;
            Console.WriteLine("Cate numere contine secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti cele {n} numere pe o singura linie, separate prin cate-un spatiu");
            string linie = Console.ReadLine();
            char[] seps = { ' ' };
            string[] tokens = linie.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            nr1 = int.Parse(tokens[0]);
            for (i=1;i<n;i++)
            {
                nr2 = int.Parse(tokens[i]);
                if (nr1 > nr2)
                    ok = false;
                nr1 = nr2;
            }
            if(ok==true)
                Console.WriteLine("Secventa este in ordine crescatoare");
            else
                Console.WriteLine("Secventa nu este in ordine crescatoare");
        }

        /// <summary>
        /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. 
        /// </summary>
        private static void P5()
        {
            int n, i, nr,nregalpoz=0;
            Console.WriteLine("Cate numere contine secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti cele {n} numere pe o singura linie, despartite prin cate un spatiu");
            string linie = Console.ReadLine();
            char[] seps = { ' ' };
            string[] tokens = linie.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            for(i=0;i<n;i++)
            {
                nr = int.Parse(tokens[i]);
                if (i == nr)
                    nregalpoz++;
            }
            if(nregalpoz!=0)
                Console.WriteLine($"In secventa sunt {nregalpoz} numere egale cu pozitia pe care apar" );
            else
                Console.WriteLine("In secventa NU exista astfel de numere");
        }

        /// <summary>
        /// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. 
        /// Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
        /// </summary>
        private static void P4()
        {
            int n, a, i,nr;
            bool ok = false;
            Console.WriteLine("Ce numar cautam in secventa?");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Cate numere contine secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti cele {n} numere pe o singura linie, separate prin cate un spatiu:");
            string linie = Console.ReadLine();
            char[] seps = { ' ' };
            string[] tokens = linie.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            for(i=0;i<n;i++)
            {
                nr = int.Parse(tokens[i]);
                if (nr == a)
                {
                    Console.WriteLine($"Numarul {a} se gaseste pe pozitia {i} in secventa introdusa");
                    ok = true;
                }
            }
            if(ok==false)
                Console.WriteLine("Numarul nu se regaseste in secventa");
            
        }

        /// <summary>
        /// Calculati suma si produsul numerelor de la 1 la n. 
        /// </summary>
        private static void P3()
        {
            int n, i, suma = 0, produs = 1;
            Console.WriteLine("Cat este n?");
            n = int.Parse(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                suma += i;
                produs *= i;
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n} este {suma}, iar produsul lor este {produs}");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
        /// </summary>
        private static void P2()
        {
            int n, neg = 0, zero = 0, poz = 0, i,nr;
            Console.WriteLine("Cate numere contine secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti cele {n} numere pe o singura linie, despartite prin cate un spatiu:");
            string linie = Console.ReadLine();
            char[] seps = { ' ' };
            string[] tokens = linie.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            for(i=0;i<n;i++)
            {
                nr = int.Parse(tokens[i]);
                if (nr < 0)
                    neg++;
                else if (nr == 0)
                    zero++;
                else if (nr > 0)
                    poz++;
            }
            Console.WriteLine($"In secventa introdusa sunt {neg} numere negative, {zero} numere egale cu zero si {poz} numere pozitive");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare.
        /// </summary>
        private static void P1()
        {
            int n,i,nrpare=0,nr;
            Console.WriteLine("Cate numere contine secventa?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti pe o singura linie cele {n} numere despartite prin cate-un spatiu:");
            string linie = Console.ReadLine();
            char[] seps = { ' ' };
            string[] tokens = linie.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            for(i=0;i<n;i++)
            {
                nr = int.Parse(tokens[i]);
                if (nr % 2 == 0)
                    nrpare++;
            }
            Console.WriteLine($"In secventa introdusa sunt {nrpare} numere pare.");
        }
    }
}
