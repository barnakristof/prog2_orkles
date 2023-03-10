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
            Helikopter helikopter1 = new Helikopter(11, 5, terkep);
            Helikopter helikopter2 = new Helikopter(1, 14, terkep);
            Szimulacio szimulacio = new Szimulacio(4, terkep);
            szimulacio.JarmuFelvetel(helikopter1);
            szimulacio.JarmuFelvetel(helikopter2);
            szimulacio.Fut();
        }

        static void Teszt4()
        {
            Terkep terkep = new Terkep(20, 20);
            Helikopter helikopter = new Helikopter(11, 5, terkep);
            Auto auto = new Auto(11, 6, terkep);
            Tank tank = new Tank(30, 10, 8, terkep);
            Szimulacio szimulacio = new Szimulacio(4, terkep);
            szimulacio.JarmuFelvetel(helikopter);
            szimulacio.JarmuFelvetel(auto);
            szimulacio.JarmuFelvetel(tank);
            szimulacio.Fut();
        }

        static void Main(string[] args)
        {
            //Teszt1();
            //Teszt2();
            //Teszt3();
            Teszt4();
        }
    }
}
