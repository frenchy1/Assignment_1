using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRAssignment_1
{
    public class Circle
    {
        private int radius;

        public Circle()
        {
            radius = 1;
        }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int GetRadius()
        {
            return this.radius;
        }
        public void SetRadius(int radius)
        {
            this.radius = radius;
        }
        public double GetCircumference()
        {
            return this.radius * 2 * Math.PI;
        }
        public double GetArea()
        {
            return this.radius * radius * Math.PI;
        }

    }

}
