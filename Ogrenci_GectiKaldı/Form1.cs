using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_GectiKaldı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                lstStudents.Items.Add(new Ogrenci(txtAd.Text, txtSoyad.Text, int.Parse(txtVize.Text), int.Parse(txtFinal.Text)));
            }
            catch
            {
                MessageBox.Show("Değerleri Giriniz");
            }
           
            AllTextsClear();
        }
        private void AllTextsClear()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtVize.Clear();
            txtFinal.Clear();
        }

   

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}

