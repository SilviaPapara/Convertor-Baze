using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor_baze
{
    class Program
    {
        // Doar pentru baze <11 
        public static int DinBin10(int numar, int b)
        {
            int nr = 0;
            int p = 1;
            int cifra = 0;
            while (numar != 0)
            {
                cifra = numar % 10;
                numar /= 10;
                nr += cifra * p;
                p *= b;

            }

            return nr;
        }

        public static int Din10inB(int n, int b)
        {
            int nr = 0;
            int p = 1;
            int r = 0;
            while (n != 0)
            {
                r = n % b;
                n = n / b;
                nr = nr + r * p;
                p = p * 10;
            }
            return nr;
        }

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int bazan = int.Parse(Console.ReadLine());
            int BazaDeTransf = int.Parse(Console.ReadLine());

            if (bazan == 10)
                Console.WriteLine("Numarul" + " " + n + " " + "este in baza 10 si este" + " " + Din10inB(n, BazaDeTransf) + " " + "in baza" + " " + BazaDeTransf);
            if(BazaDeTransf==10)

                Console.WriteLine("Numarul" + " " + n + " " + "este in baza"+ " "+bazan+" "+"si este" +" "+ DinBin10(n,bazan) + " " + "in baza" + " " + BazaDeTransf);
            if(bazan!=10 && BazaDeTransf!=10)
            {
                int k = DinBin10(n, bazan);
                int p = Din10inB(k, BazaDeTransf);
                Console.WriteLine("Numarul" + " " + n + " " + " este in baza" + " " + bazan + " " + "si este" + " " + p + " " + "in baza" + " " + BazaDeTransf);
            }
        }
    }
}
