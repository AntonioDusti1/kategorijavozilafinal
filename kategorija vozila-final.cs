using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kategorijavozlia3
{
    public partial class Form1 : Form
    {
        private int brojMotocikala= 0;
        private int brojAutomobila = 0;
        private int brojKamiona = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGodinaProizvodnje.Text, out int godina) || godina < 1886 || godina > DateTime.Now.Year)
            {
                MessageBox.Show("Unesite valjanu godinu proizvodnje.");
                return;
            }
            if (!int.TryParse(txtBrojKotača.Text, out int brojKotaca) || brojKotaca < 2 || brojKotaca % 2 != 0)
            {
                MessageBox.Show("Unesite validan broj kotača (mora biti paran i veći od 2).");
                return;
            }
            string model = txtModel.Text;
            if (brojKotaca == 2)
            {
                brojMotocikala++;
                txtIspis.AppendText($"Dodano vozilo: {model} - " +
                    $"Motocikl\r\n");
            }
            else if (brojKotaca == 4)
            {
                brojAutomobila++;
                txtIspis.AppendText($"Dodano vozilo: {model} - " +
                    $"Automobil\r\n");
            }
            else
            {
                brojKamiona++;
                txtIspis.AppendText($"Dodano vozilo: {model} - " +
                    $"Kamion\r\n");
            }

            txtModel.Clear();
            txtGodinaProizvodnje.Clear();
            txtBrojKotača.Clear();
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Podaci su primljeni.");
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            txtIspis.AppendText($"\nUkupan broj vozila:\r\n");
            txtIspis.AppendText($"Motocikli: {brojMotocikala}\r\n");
            txtIspis.AppendText($"Automobili: {brojAutomobila}\r\n");
            txtIspis.AppendText($"Kamioni: {brojKamiona}\r\n");
        }
    }
}
