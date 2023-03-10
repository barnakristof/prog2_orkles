using System;
namespace Orokles
{
    class Szimulacio : TerkepEsJarmuRajzolo
    {

        void EgyIdoEgysegEltelt()
        {
            for (int i = 0; i < jarmuvekN; i++)
            {
                if (jarmuvek[i] is MozgoJarmu)
                {
                    (jarmuvek[i] as MozgoJarmu).Mozog();
                }
            }
        }

        public void Fut()
        {
            while (true)
            {
                EgyIdoEgysegEltelt();
                Kirajzol();
                System.Threading.Thread.Sleep(500);
            }
        }

        public Szimulacio(int meret, Terkep terkep) : base(meret, terkep)
        {
            
        }
    }
}
