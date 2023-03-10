using System;
namespace Orokles
{
    abstract class MozgoJarmu : Jarmu 
    {
        float iranyX;
        float iranyY;
        public float IranyX { get { return iranyX; } }
        public float IranyY { get { return iranyY; } }

        protected void UjIranyVektor(float iranyX, float iranyY)
        {
            this.iranyX = iranyX;
            this.iranyY = iranyY;
        }

        public abstract void Mozog();

        public MozgoJarmu(char azonosito, float x, float y, Terkep terkep) : base(azonosito, x, y, terkep)
        {

        }
    }
}
