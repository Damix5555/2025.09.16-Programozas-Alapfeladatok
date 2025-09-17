using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._09._16HF
{
    internal class Program
    {
        static void F1()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
        }
        static void F2()
        {
            Console.Write("Név? : ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Hello szia, {nev}!");
        }
        static void F3()
        {
            Console.Write("Adj egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine($"kétszerese: {szam * 2}");
        }
        static void F4()
        {
            Console.Write("Adj egy számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Adj még egy számot: ");
            int szam2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Összeg: {szam1 + szam2}");
            Console.WriteLine($"Különbség: {szam1 - szam2}");
            Console.WriteLine($"Szorzat: {szam1 * szam2}");
            if (szam2 != 0)
            {
                Console.WriteLine($"Hányados: {(double)szam1 / szam2}");
            }
        }
        static void F5()
        {
            Console.Write("Adj egy számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Adj még egy számot: ");
            int szam2 = int.Parse(Console.ReadLine());
            if (szam1 > szam2)
            {
                Console.WriteLine($"A nagyobb szám: {szam1}");
            }
            else if (szam2 > szam1)
            {
                Console.WriteLine($"A nagyobb szám: {szam2}");
            }
            else
            {
                Console.WriteLine("A két szám egyenlő.");
            }
        }
        static void F6()
        {
            Console.Write("Adj egy számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Adj még egy számot: ");
            int szam2 = int.Parse(Console.ReadLine());
            Console.Write("Adj még egy számot: ");
            int szam3 = int.Parse(Console.ReadLine());
            int legkisebb = szam1;
            if (szam2 < legkisebb)
            {
                legkisebb = szam2;
            }
            if (szam3 < legkisebb)
            {
                legkisebb = szam3;
            }
            Console.WriteLine($"A legkisebb szám: {legkisebb}");
        }
        static void F7()
        {
            Console.Write("első oldal hossza: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("második oldal hossza: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("harmadik oldal hossza ");
            int c = int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Szerkeszthető háromszög.");
            }
            else
            {
                Console.WriteLine("Nem szerkeszthető a háromszög.");
            }
        }
        static void F8() 
        {
            Console.Write("Adj egy pozitív számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Adj még egy pozitív számot: ");
            int szam2 = int.Parse(Console.ReadLine());
            if (szam1 > 0 && szam2 > 0)
            {
                double szamtaniKozep = (szam1 + szam2) / 2.0;
                double mertaniKozep = Math.Sqrt(szam1 * szam2);
                Console.WriteLine($"Számtani közép: {szamtaniKozep}");
                Console.WriteLine($"Mértani közép: {mertaniKozep}");
            }
            else
            {
                Console.WriteLine("Mindkét szám pozitív legyen!");
            }
        }
        static void F9()
        {
            Console.Write("a együttható: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b együttható: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c együttható: ");
            double c = double.Parse(Console.ReadLine());
            double diszkriminans = b * b - 4 * a * c;
            if (diszkriminans > 0)
            {
                Console.WriteLine("Két valós gyök van.");
            }
            else if (diszkriminans == 0)
            {
                Console.WriteLine("Egy valós gyök van.");
            }
            else
            {
                Console.WriteLine("Nincs valós gyök.");
            }
        }
        static void F10()
        {
            Console.Write("a együttható: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b együttható: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c együttható: ");
            double c = double.Parse(Console.ReadLine());
            double diszkriminans = b * b - 4 * a * c;
            if (diszkriminans > 0)
            {
                double x1 = (-b + Math.Sqrt(diszkriminans)) / (2 * a);
                double x2 = (-b - Math.Sqrt(diszkriminans)) / (2 * a);
                Console.WriteLine($"Két valós gyök van: x1 = {x1}, x2 = {x2}");
            }
            else if (diszkriminans == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Egy valós gyök van: x = {x}");
            }
            else
            {
                Console.WriteLine("Nincs valós gyök.");
            }
        }
        static void F11()
        {
            Console.Write("Első befogó hossza: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Második befogó hossza: ");
            double b = double.Parse(Console.ReadLine());
            if (a > 0 && b > 0)
            {
                double c = Math.Sqrt(a * a + b * b);
                Console.WriteLine($"Az átfogó hossza: {c:F2}");
            }
            else
            {
                Console.WriteLine("A befogók nem pozitivak!");
            }
        }
        static void F12()
        {
            Console.Write("Első él hossza: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Második él hossza: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Harmadik él hossza: ");
            double c = double.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0)
            {
                double felszin = 2 * (a * b + b * c + a * c);
                double terfogat = a * b * c;
                Console.WriteLine($"Felszín: {felszin}");
                Console.WriteLine($"Térfogat: {terfogat}");
            }
            else
            {
                Console.WriteLine("Az élek hossza pozitívnak kell hiogy legyen.");
            }
        }
        static void F13()
        {
            Console.Write("Add meg a kör átmérőjét: ");
            double atmero = double.Parse(Console.ReadLine());
            if (atmero > 0)
            {
                double sugar = atmero / 2;
                double kerulet = 2 * Math.PI * sugar;
                double terulet = Math.PI * sugar * sugar;
                Console.WriteLine($"Kerület: {kerulet:F2}");
                Console.WriteLine($"Terület: {terulet:F2}");
            }
            else
            {
                Console.WriteLine("Az átmérőnek pozitívnak kell hogy legyen.");
            }
        }
        static void F14()
        {
            Console.Write("Körív sugara: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Középponti szög fokban: ");
            double alfa = double.Parse(Console.ReadLine());
            if (r > 0 && alfa > 0 && alfa <= 360)
            {
                double ivHossza = 2 * Math.PI * r * (alfa / 360);
                double korivTerulet = (Math.PI * r * r) * (alfa / 360);
                Console.WriteLine($"Körív hossza: {ivHossza:F2}");
                Console.WriteLine($"Körív területe: {korivTerulet:F2}");
            }
            else
            {
                Console.WriteLine("A sugárnak pozitívnak kell lennie");
            }
        }
        
        static void F15()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("A szám pozitív legyen");
            }
        }

        static void F16()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("A szám pozitív legyen");
            }
        }
        
        static void F17()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("A szám pozitív legyen");
            }
        }
        static void F18()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                int osztoOsszeg = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        osztoOsszeg += i;
                    }
                }
                Console.WriteLine($"Osztok összege: {osztoOsszeg}");
            }
            else
            {
                Console.WriteLine("A szám pozitív legyen");
            }
        }
        static void F19()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                int osztoOsszeg = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        osztoOsszeg += i;
                    }
                }
                if (osztoOsszeg == 2 * n)
                {
                    Console.WriteLine("Tökéletes szám.");
                }
                else
                {
                    Console.WriteLine("Nem tökéletes szám.");
                }
            }
            else
            {
                Console.WriteLine("A szám pozitív legyen");
            }
        }
        
        static void F20()
        {
            Console.Write("Adj meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Adj meg egy számot: ");
            int b = int.Parse(Console.ReadLine());
            if (a > 0 && b >= 0)
            {
                int hatvany = 1;
                for (int i = 1; i <= b; i++)
                {
                    hatvany *= a;
                }
                Console.WriteLine($"{a} a {b}. hatványon: {hatvany}");
            }
            else
            {
                Console.WriteLine("A szám pozitív legyen");
            }
        }
        /*
        static void F21()
        {
            int pozszam;
            do
            {
                Console.Write("Adj meg egy (pozitív) számot: ");
                szam = int.Parse(Console.ReadLine());
            } while (szam <= 0);
            Console.WriteLine($"A megadott szám: {pozszam}");
        }
        */
        static void F22()
        {
            int szam;
            int osszeg = 0;
            do
            {
                Console.Write("Adj meg egy számot (10-nél kisebb): ");
                szam = int.Parse(Console.ReadLine());
                if (szam < 10)
                {
                    osszeg += szam;
                }
            } while (szam < 10);
            Console.WriteLine($"beolvasott számok összege: {osszeg}");
        }
        
        static void F23()
        {
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            int oszto = 1;
            while (szam % 2 == 0)
            {
                szam /= 2;
                oszto *= 2;
            }
            Console.WriteLine($"szám: {oszto} * {szam}");
        }
        static void F24()
        {
            string s;
            do
            {
                Console.Write("Adj meg egy szót: ");
                s = Console.ReadLine();
            } while (s.ToLower() != "alma");
            Console.WriteLine("Az alma gyümölcs!");

        }
        static void F25()
        {
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            while (szam >= 3)
            {
                szam -= 3;
            }
            Console.WriteLine($"A hárommal való maradékos osztás eredménye: {szam}");
        }
        static void F26()
        {
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam > 1)
            {
                bool prim = true;
                for (int i = 2; i <= Math.Sqrt(szam); i++)
                {
                    if (szam % i == 0)
                    {
                        prim = false;
                        break;
                    }
                }
                if (prim)
                {
                    Console.WriteLine("Prím.");
                }
                else
                {
                    Console.WriteLine("Nem prím.");
                }
            }
            else
            {
                Console.WriteLine("Nem prím.");
            }
        }
        //Innen nem sikerült
        /*
        static void F27()
        {
           
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 2)
            {
                Console.WriteLine("Prímszámok:");
                for (int i = 2; i <= n; i++)
                {
         
                }
            else
            {
                Console.WriteLine("Nincs prím.");
            }
        }
        static void F28()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLinew());

            
        }
         
        static void F29() 
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());

        }
        */
        static void F30()
        {

            Console.Write("Adj meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Adj meg egy számot: ");
            int b = int.Parse(Console.ReadLine());
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
            Console.WriteLine($"legnagyobb közös osztó: {a}");

        }
            static void F31()
        {
                Console.Write("Adj meg egy számot: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Adj meg egy számot: ");
                int b = int.Parse(Console.ReadLine());
                int lkt = (a * b) / 1;
                while (lkt % a != 0 || lkt % b != 0)
                {
                    lkt++;
                }
                Console.WriteLine($"legkisebb közös többszörös: {lkt}");
        }
       
        static void Main(string[] args)
        {
            F1();
            F2();
            F3();
            F4();
            F5();
            F6();
            F7();
            F8();
            F9();
            F10();
            F11();
            F12();
            F13();
            F14();            
            F15();
            F16();            
            F17();
            F18();
            F19();         
            F20();
          //F21();
            F22(); 
            F23();
            F24();
            F25();
            F26();
          //F27();
          //F28();
          //F29();
            F30();
            F31();
            
            Console.ReadKey();
        }
        
    }
}
