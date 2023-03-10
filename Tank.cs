using System;
namespace Orokles
{
    sealed class Tank : Auto
    {

        public override bool IdeLephet(float x, float y)
        {
            return true;
        }

        int uzemanyag;

        public override void Mozog()
        {
            if (uzemanyag >= 10)
            {
                uzemanyag -= 10;
                X += IranyX;
                Y += IranyY;
            }
        }

        public Tank(int uzemanyag, float x, float y, Terkep terkep) : base(x, y, terkep, 'T')
        {
            this.uzemanyag = uzemanyag;
        }
    }
}
