using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthKalendarKontrola
{
    public partial class Zaglavlje : Form
    {
        public Zaglavlje()
        {
            InitializeComponent();
        }

        private void terminButton_Click(object sender, EventArgs e)
        {
            TimeSpan razdobljeTermina = kalendar.SelectionEnd - kalendar.SelectionStart;
            if (razdobljeTermina.Days < 1)
            {
                MessageBox.Show("Korištenjem tipke SHIFT odaberite opseg datuma.");
                return;
            }
            MessageBox.Show($"Rezervirali ste usluge u trajanju od {razdobljeTermina.Days} dana");
            MessageBox.Show($"Vasa rezervacija počinje {kalendar.SelectionStart.ToShortDateString()}, a završava se {kalendar.SelectionEnd.ToShortDateString()}");
        }
    }
}
