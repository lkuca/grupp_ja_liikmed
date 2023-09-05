using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace grupp_ja_liikmed
{
    public class liikmed
    {

        private readonly string Nimi;
        private readonly int Aasta;
        private readonly int Kuupäev;
        private readonly int Kuu;


        public liikmed(string nimi, int aasta, int kuupäev, int kuu)
        {
            this.Aasta = aasta;
            this.Nimi = nimi;
            this.Kuupäev = kuupäev;
            this.Kuu = kuu;

        }
        public int aasta { get => Aasta; }
        public int kuupäev { get => Kuupäev; }
        public int kuu { get => Kuu; }
        public string nimi { get => Nimi; }

        public void randomyear()
        {
            Random r = new Random(); int aasta = r.Next(2000,2023);
        }
        public void randomkuupaev()
        {
            Random r = new Random(); int kuupäev = r.Next(1,31);
        }
        public void randomkuu()
        {
            Random r = new Random(); int kuu = r.Next(1,12);
        }
        public static char randomnimi(string s)
        {

        }
        //    public List<string> Liik { get; } = new List<string>();
        //    private readonly int daite;
        //    public liikmed(int da_te)
        //    {
        //       daite  = da_te;
        //    }


        //    public bool AddDaite(string dat)
        //    {
        //        if (Liik.Contains(dat)) return false;
        //        if (Liik.Count >= daite) return false;
        //        Liik.Add(dat);
        //        return true;
        //    }

        //    public int GetdaiteCount()
        //    {
        //        return Liik.Count;
        //    }


        //    public bool Hasdaite(string dat)
        //    {
        //        return Liik.Contains(dat);
        //    }
    }
    
}
