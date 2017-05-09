using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpVezba9V2MernaStanica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SistemServis.SistemServisClient servis = new SistemServis.SistemServisClient();
            servis.TemperaturaAsync(textNazivStanice.Text, Convert.ToDouble(textTemperaturaStanice.Text), dateTimePicker1.Value);
        }
    }
}
