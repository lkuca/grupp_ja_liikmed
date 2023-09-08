using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace grupp_ja_liikmed
{
    public class liikmed
    {
        public int aasta { get => aasta; }
        public int kuupäev { get => kuupäev; }
        public int kuu { get => kuu; }
        public string nimi { get => nimi; }


        public liikmed()
        {
           

        }
        

        //public void randomyear()
        //{
        //    Random r = new Random(); int aasta = r.Next(2000,2023);
        //}
        //public void randomkuupaev()
        //{
        //    Random r = new Random(); int kuupäev = r.Next(1,31);
        //}
        //public void randomkuu()
        //{
        //    Random r = new Random(); int kuu = r.Next(1,12);
        //}

        public void taishaalikud()
        {

            int length = 7;

            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();
            char taht;
            //string nimi;

            for (int i = 0; i < length; i++)
            {
                //дабл это тип с плавающей запятой, размер которого больше или равен размеру типа double
                double flt = random.NextDouble();
                //Функции floor возвращают значение с плавающей запятой, которое представляет наибольшее целое число, не превосходящее x . Ошибка не возвращается.
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                taht = Convert.ToChar(shift + 65);
                str_build.Append(taht);
                


            }
            int aasta = random.Next(2000, 2023);
            int kuupäev = random.Next(1, 31);
            int kuu = random.Next(1, 12);
            string nimi = str_build.ToString();
            Console.WriteLine(nimi + ' ' + aasta + '-' + kuupäev + '-' + kuu);
            Console.WriteLine(nimi + ' ' + aasta + '-' + kuupäev + '-' + kuu);
            Console.WriteLine(nimi + ' ' + aasta + '-' + kuupäev + '-' + kuu);
            Console.WriteLine(nimi + ' ' + aasta + '-' + kuupäev + '-' + kuu);
            //Random rand = new Random();


            //string a = "a";
            //string e = "e";
            //string i = "i";
            //string o = "o";
            //string u = "u";
            //string y = "y";
            ////}
            ////public void kaashalikud()
            ////{ 
            //string b = "b";
            //string c = "c";
            //string d = "d";
            //string f = "f";
            //string g = "g";
            //string h = "h";
            //string j = "j";
            //string k = "k";
            //string l = "l";
            //string m = "m";
            //string n = "n";
            //string p = "p";
            //string q = "q";
            //string r = "r";
            //string s = "s";
            //string t = "t";
            //string v = "v";
            //string w = "w";
            //string x = "x";
            //string z = "z";

            //short aa = (short)Convert.ToInt32("aa");

            //string nimi = rand % (a, e, i, o, u, y, b, c, d, f, g, h, j, k, l, m, n, p, q, r, s, t, v, w, x, z);


            //string bruh = rand % (taishaalikud();
        }


        //public static char randomnimi(string s)
        //{

        //}
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
