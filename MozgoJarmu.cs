using System;
namespace Orokles
{
    abstract class MozgoJarmu : Jarmu 
    {
        float iranyX = 1;
        float iranyY = 1;
        public float IranyX { get { return iranyX; } }
        public float IranyY { get { return iranyY; } }

        public void UjIranyVektor(float iranyX, float iranyY)
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
