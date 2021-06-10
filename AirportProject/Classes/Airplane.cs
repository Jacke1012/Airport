using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportProject.Classes;

namespace AirportProject
{
    public class Airplane
    {
        public string regestration;
        public string callSign;
        public DateTime dateTookInService;
        public Model model;
        public Engine engine;

        public Airplane(string regestration, Model model, Engine engine)
        {
            this.regestration = regestration;
            this.model = model;
            this.engine = engine;
        }

        public override string ToString()
        {
            return $"{regestration}\t{model}\t{engine}";
        }

        public void ShowInfo()
        {

        }
    }
}
