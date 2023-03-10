using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Program
    {
        static void Teszt1()
        {
            Terkep terkep = new Terkep(80, 25);
            TerkepRajzolo rajzolo = new TerkepRajzolo(terkep);
            rajzolo.Kirajzol();
        }

        static void Teszt2()
        {
            Terkep terkep = new Terkep(80, 25);
            TerkepEsJarmuRajzolo rajzolo = new TerkepEsJarmuRajzolo(5, terkep);
            Jarmu jarmu = new Jarmu('*', 10, 10, terkep);
            rajzolo.JarmuFelvetel(jarmu);
            rajzolo.Kirajzol();
        }

        static void Teszt3()
        {
            Terkep terkep = new Terkep(20, 20);
            Helikopter helikopter1 = new Helikopter(terkep, 11, 5);
            Helikopter helikopter2 = new Helikopter(terkep, 1, 14);
            Szimulacio szimulacio = new Szimulacio(4, terkep);
            szimulacio.JarmuFelvetel(helikopter1);
            szimulacio.JarmuFelvetel(helikopter2);
            szimulacio.Fut();
        }

        static void Main(string[] args)
        {
            //Teszt1();
            //Teszt2();
            Teszt3();
            /*Console.WriteLine("asdasdasdasdas");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
            Console.Read();*/
        }
    }
}
