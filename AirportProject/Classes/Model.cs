using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportProject;

namespace AirportProject.Classes
{
    public class Model
    {
        public int passengerCapasity;
        public Dimensions dimentions;
        public string modelName;

        public Model(string modelName, int passengerCapasity, Dimensions dimentions)
        {
            this.modelName = modelName;
            this.passengerCapasity = passengerCapasity;
            this.dimentions = dimentions;
        }

        public void OpenInfo()
        {
            ModelInfo engineInfo = new ModelInfo(this);
            engineInfo.Show();
        }

        public override string ToString()
        {
            return modelName;
        }
    }
}
