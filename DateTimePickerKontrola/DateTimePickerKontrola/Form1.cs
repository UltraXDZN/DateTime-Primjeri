using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePickerKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRezervacija_Click(object sender, EventArgs e)
        {
            richTextBoxIspis.Text =
                "Vas datum leta je: \n" +
                $"{dateTimePicker1.Text} \n" +
                "Vase vrijeme polaska je: \n" +
                $"{dateTimePicker2.Text}";
        }
    }
}
