using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpVezba9V2Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            JavniServis.JavniServisClient servis = new JavniServis.JavniServisClient();
            textBox1.Text = servis.ProsecneTemperatureAsync(textNazivStanice.Text, dateTimePicker1.Value, dateTimePicker2.Value).ToString();

        }
    }
}
