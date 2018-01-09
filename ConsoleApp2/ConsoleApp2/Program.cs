using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tmp;
            int m = 47527;
            int[] T = new int[m];
            int[] wartosci = new int[3744];
            string path = @"/home/Dave/Downloads";
            int k = 0;
            int wartosc = 0;
            tmp = File.ReadAllLines(path);
            int h;
            foreach(string a in tmp)
            {
                for(int i = 0; i < a.Length; i++)
                {
                    wartosc += a[i];
                }
                wartosci[k] = wartosc;
                wartosc = 0;
                k++;
            }
            for (int i = 0; i < T.Length; i++)
            {
                T[i] = 0;
                Console.Write(T[i]);
            }
            for(int i = 0; i < wartosci.Length; i++)
            {
                h = wartosci[i] % m;
                T[h]++;
            }
            int Zera = 0;
            int max = T[0];
            float liczilosc=0;
            float liczwartosc=0;
            for(int i = 0; i < m; i++)
            {
                if (T[i] == 0)
                {
                    Zera++;
                }
                if (T[i] > max)
                {
                    max = T[i];
                }
                if (T[i] != 0)
                {
                    liczilosc++;
                    liczwartosc = liczwartosc + T[i];
                }
            }
            Console.WriteLine("Ilosc zer:"+Zera);
            Console.WriteLine("Najwieksza wartosc:" + max);
            Console.WriteLine("Srednia wartosc niezerowych"+liczwartosc/liczilosc);
            Console.ReadLine();
        }
    }
}
