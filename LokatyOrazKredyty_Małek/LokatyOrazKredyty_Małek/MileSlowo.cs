using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LokatyOrazKredyty_Małek
{
    public partial class MileSlowo : Form
    {
        public MileSlowo()
        {
            InitializeComponent();
        }

        private void KmbtnOczywiscie_Click(object sender, EventArgs e)
        {
            KMlblTak.Visible = true;
            KMlblNie.Visible = false;
        }

        private void KMbtnNie_Click(object sender, EventArgs e)
        {
            KMlblNie.Visible = true;
            KMlblTak.Visible = false;
        }

        private void KMbtnPowrot_Click(object sender, EventArgs e)
        {
            foreach (Form Formularz in Application.OpenForms)
            {
                if (Formularz.Name == "Kokpit")
                {
                    this.Hide();
                    Formularz.Show();
                    return;
                }
            }
            Kokpit FormularzKokpit = new Kokpit();
            this.Hide();
            FormularzKokpit.Show();
        }
    }
}
