using System;
namespace Orokles
{
    class Jarmu
    {
        char azonosito;
        float x, y;
        Terkep terkep;

        public Jarmu(char azonosito, float x, float y, Terkep terkep)
        {

            this.azonosito = azonosito;
            this.x = x;
            this.y = y;
            this.terkep = terkep;
      
        }

        public char Azonosito { get { return azonosito; } }
        public float X { get { return x; } protected set { x = value; } }
        public float Y { get { return y; } protected set { y = value; } }

        public virtual bool IdeLephet(float x, float y)
        {
            return terkep.TerkepenBeluliPozicio(x, y);
        }
    }
}
