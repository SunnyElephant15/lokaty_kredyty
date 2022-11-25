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
    public partial class Kokpit : Form
    {
        public Kokpit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form Formularz in Application.OpenForms)
            {
                if (Formularz.Name == "Lokaty")
                {
                    this.Hide();
                    Formularz.Show();
                    return;
                }
            }
            Lokaty FormularzLokaty = new Lokaty();
            this.Hide();
            FormularzLokaty.Show();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form Formularz in Application.OpenForms)
            {
                if (Formularz.Name == "Kredyty")
                {
                    this.Hide();
                    Formularz.Show();
                    return;
                }
            }
            Kredyty FormularzKredyty = new Kredyty();
            this.Hide();
            FormularzKredyty.Show();
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form Formularz in Application.OpenForms)
            {
                if (Formularz.Name == "MileSlowo")
                {
                    this.Hide();
                    Formularz.Show();
                    return;
                }
            }
            MileSlowo FormularzMileSlowo = new MileSlowo();
            this.Hide();
            FormularzMileSlowo.Show();
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Form Formularz in Application.OpenForms)
            {
                if (Formularz.Name == "KMsprawdzianSystematyczneOszczedzanie")
                {
                    this.Hide();
                    Formularz.Show();
                    return;
                }
            }
            KMsprawdzianSystematyczneOszczedzanie FormularzKMsprawdzianSystematyczneOszczedzanie = new KMsprawdzianSystematyczneOszczedzanie();
            this.Hide();
            FormularzKMsprawdzianSystematyczneOszczedzanie.Show();
            return;
        }
    }
}

