using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama_pembeli;
            string nama_bakso;
            double jumlah;
            double harga;
            double hasil;
            nama_pembeli = textBox1.Text;
            nama_bakso = textBox2.Text;
            jumlah = int.Parse(textBox3.Text);
            harga = int.Parse(textBox4.Text);
            hasil = jumlah * harga;
            MessageBox.Show("Nama yang beli : " + nama_pembeli + "\n" + "baksonya" + nama_bakso +
                "\n" + "jumlah" + jumlah + "\n" + "Harga satuanya" + harga + "\n" + "jumlah bayar :" + hasil +"\nTerima Kasih");
        }
    }
}
