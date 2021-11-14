using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using FirstWCFService_035;

namespace ServerConfigForm_P5_20190140035
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnOrOff.Text = "Server ON";
            labelKet.Text = "Klik OFF untuk Mematikan Server";
            buttonOn.Enabled = false;
            buttonOff.Enabled = true;
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
            labelOnOrOff.Text = "Server OFF";
            labelKet.Text = "Klik ON untuk Menjalankan Server";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
