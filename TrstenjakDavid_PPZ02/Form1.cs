using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrstenjakDavid_PPZ02
{
    public partial class Form1 : Form
    {
        List<klasa1> listaPica = new List<klasa1>();
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            klasa1 pica = new klasa1();

            listaPica.Add(pica);

            MessageBox.Show("Uspješan unos. ", "USPJEH!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelVrijednost_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar_postotak_Scroll(object sender, EventArgs e)
        {
            labelVrijednost.Text = Convert.ToString(trackBar_postotak.Value);
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            richTextBox_ispis.Clear();
            foreach (klasa1 klasa1 in listaPica)
            {
                richTextBox_ispis.AppendText(klasa1.ToString());
            }
        }
    }
}
