using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekAkhir_AyuLestari
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Membuat instance form berikutnya (misal Form3)
            Form3 form3 = new Form3();

            // Menampilkan form3
            form3.Show();

            // Menyembunyikan form saat ini (Form1)
            this.Hide();
        }
    }
}