using System;
namespace Orokles
{
    class TerkepEsJarmuRajzolo : TerkepRajzolo
    {
        protected Jarmu[] jarmuvek;
        protected int jarmuvekN;
        public void JarmuFelvetel(Jarmu jarmu)
        {
            jarmuvek[jarmuvekN++] = jarmu;
        }

        protected override char MiVanItt(int x, int y)
        {
            int i = 0;
            bool talalat = false;
            while (i < jarmuvekN && !talalat)
            {
                if (jarmuvek[i].X == x && jarmuvek[i].Y == y)
                {
                    talalat = true;
                }
                else
                {
                    i++;
                }
            }
            if (i < jarmuvekN)
            {
                return jarmuvek[i].Azonosito;
            }
            else
            {
                return base.MiVanItt(x, y);
            }
        }

        public TerkepEsJarmuRajzolo(int meret, Terkep terkep) : base(terkep)
        {
            this.jarmuvek = new Jarmu[meret];
        }
    }
}
