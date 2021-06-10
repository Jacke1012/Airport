using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.Classes
{
    public class Dimensions
    {
        public float width, height, length;

        public Dimensions(float width, float height, float length)
        {
            this.width = width;
            this.height = height;
            this.length = length;
        }

        public override string ToString()
        {
            return $"{width}m x {height}m x {length}m";
        }
    }
}
