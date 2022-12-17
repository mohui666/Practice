using System;

namespace OOP
{
    class Vector3
    {
        private float x;
        private float y;
        private float z;

        public void SetX(float temp)
        {
            x = temp;
        }
        public void SetY(float temp)
        {
            y = temp;
        }
        public void SetZ(float temp)
        {
            z = temp;
        }
        public double Length()
        {
            return Math.Sqrt(x*x+y*y+z*z);
        }
    }
}