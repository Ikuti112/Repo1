using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace zad2
{
    struct nazwiska
    {
        private int ilosc;
        private String nazwisko;
        public int Ilosc
        {
            get
            {
                return ilosc;
            }
            set
            {
                ilosc = value;
            }
        }
        public String Nazwisko
        {
            get
            {
                return nazwisko;
            }
            set
            {
                nazwisko = value;
            }
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            nazwiska[] tmp;
            int m = 47527;
            int m2 = 100;
            int[] T = new int[m];
            int[] T2 = new int[m2];
            int[] wartosci = new int[30000];
            string path = @"/home/Dave/Downloads";
            int k = 0;
            int wartosc = 0;
            tmp = File.ReadAllLines(path);
            int h;
            foreach (nazwiska a in tmp)
            {
                for (int i = 0; i < 30000; i++)
                {
                    wartosc += a.Ilosc;
                }
                wartosci[k] = wartosc;
                wartosc = 0;
                k++;
            }
        }
    }
}

