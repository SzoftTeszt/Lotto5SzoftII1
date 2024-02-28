using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto5Adat.Models
{
    public class LottoSzam
    {
        public int Id { get; set; }
        public int Szam1 { get; set; }
        public int Szam2 { get; set; }
        public int Szam3 { get; set; }
        public int Szam4 { get; set; }
        public int Szam5 { get; set; }

        public LottoSzam()
        {
        }     
        
        public LottoSzam(string sor)
        {
            string[] t = sor.Split(";");
            if (t.Length == 5)
            {
                int[] szamok = new int[t.Length];
                for (int i = 0; i < t.Length; i++)
                {
                    try
                    {
                        szamok[i] = Convert.ToInt32(t[i]);
                    }
                    catch {
                        throw new ArgumentException("Line error", "sor");
                    }
                    if (szamok[i]<1 || szamok[i]>90)
                        throw new ArgumentException("Line error", "sor");
                }

                HashSet<int> s = new HashSet<int>(szamok);
                if (s.Count !=5) throw new ArgumentException("Line error", "sor");
                Szam1 = szamok[0];
                Szam2 = szamok[1];
                Szam3 = szamok[2];
                Szam4 = szamok[3];
                Szam5 = szamok[4];
            }
            else throw new ArgumentException("Line error","sor");
        }   
        
        public LottoSzam(int[] tomb): this(tomb[0], tomb[1], tomb[2], tomb[3], tomb[4])
        {
        }

        public LottoSzam(int szam1, int szam2, int szam3, int szam4, int szam5)
        {
            Szam1 = szam1;
            Szam2 = szam2;
            Szam3 = szam3;
            Szam4 = szam4;
            Szam5 = szam5;
        }

        public override string? ToString()
        {
            return $"({Szam1}, {Szam2}, {Szam3}, {Szam4}, {Szam5})";
        }
    }
}
