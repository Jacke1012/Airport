using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportProject.Classes;

namespace AirportProject
{
    public partial class ModelInfo : Form
    {
        Model model;
        public ModelInfo(Model model)
        {
            this.model = model;
            InitializeComponent();
        }

        private void ModelInfo_Load(object sender, EventArgs e)
        {
            tbxModel.Text = model.modelName;
            tbxCap.Text = model.passengerCapasity.ToString();
            tbxDim.Text = model.dimentions.ToString();
        }
    }
}
