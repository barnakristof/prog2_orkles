using System;
namespace Orokles
{
    class Helikopter : MozgoJarmu
    {

        float sebesseg = 1;

        public void Gyorsit()
        {
            sebesseg += 0.1f;
        }

        public void Lassit()
        {
            if (sebesseg >= 0.1f)
            {
                sebesseg -= 0.1f;
            }
        }

        public override void Mozog()
        {
            float newX = X + (IranyX * sebesseg);
            float newY = Y + (IranyY * sebesseg);

            if (IdeLephet(newX, newY))
            {
                X = newX;
                Y = newY;
            }
        }
        

        public Helikopter( float x, float y,Terkep terkep) : base('H', x, y, terkep)
        {
            
        }
    }
}
