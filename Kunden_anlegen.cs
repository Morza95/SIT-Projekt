using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Bike___SIT_2018
{
    public partial class Kunden_anlegen : Form
    {
        public Kunden_anlegen()
        {
            InitializeComponent();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            Show(Startseite);
            Me.hide();
        }
    }
}
