using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject.Classes
{
    public class Engine
    {
        public float thrust;
        public float fuelUsage;
        public string engineName;

        public Engine(string engineName,float thrust, float fuelUsage)
        {
            this.thrust = thrust;
            this.fuelUsage = fuelUsage;
            this.engineName = engineName;
        }


        public override string ToString()
        {
            return engineName;
        }
    }
}
