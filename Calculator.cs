using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Calculator : Form
    {
        double x;
        double y;
        double z;
        double vysledek;
        public Calculator()
        {
            InitializeComponent();
            
        }

        private void vypocitej_Click(object sender, EventArgs e)
        {
            x = double.Parse(txtX.Text);
            y = double.Parse(txtY.Text);
            z = double.Parse(txtZ.Text);
            if (rbtnPrimaUmernost.Checked)
            { primaUmernost(x, y, z);
            } else
            {
                neprimaUmernost(x, y, z);
            }
            vysledek = Math.Round(vysledek, 3);
            lblResult.Text = vysledek.ToString();
        }

        private double primaUmernost(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            vysledek = (z / x) * y;
            return vysledek;
        }
        private double neprimaUmernost(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            vysledek = (x/z)*y;
            return vysledek;
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            pouzeCisla(sender, e);            
        }
        private void pouzeCisla(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }

        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            pouzeCisla(sender, e);
        }

        private void txtZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            pouzeCisla(sender, e);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikace byla vytvořena v roce 2017" + Environment.NewLine + "Vytvořil: Josef Trejbal", "Informace");
        }
    }
}
