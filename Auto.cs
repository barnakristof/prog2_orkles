using System;
namespace Orokles
{
    class Auto : MozgoJarmu
    {

        public override bool IdeLephet(float x, float y)
        {
            return base.IdeLephet(x, y) && terkep.Magassag(x, y) > 0;
        }

        public override void Mozog()
        {
            float kulonbseg = terkep.Magassag(X, Y) - terkep.Magassag(X + IranyX, Y + IranyY);
            if (kulonbseg < 0)
            {
                UjIranyVektor(IranyX * 2, IranyY * 2);
            }
            else if (kulonbseg > 0)
            {
                UjIranyVektor(IranyX / 2, IranyY / 2);
            }
            else
            {
                UjIranyVektor(1, 1);
            }

            X += IranyX;
            Y += IranyY;
        }

        public Auto(float x, float y, Terkep terkep, char azonosito = 'A') : base(azonosito, x, y, terkep)
        {
            
        }
    }
}
