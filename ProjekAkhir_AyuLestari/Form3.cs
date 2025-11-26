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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cbbukuTulis, cbbolpoin, cbpensil, cbpenggaris, cbpenghapus, cbtotalBiaya, cbuang, cbbiayaPajak, cbtotalPembayaran, cbkembalian;
            double hrgbukuTulis, hrgbolpoin, hrgpensil, hrgpenggaris, hrgpenghapus;

            cbbukuTulis = double.Parse(this.cbbukuTulis.Text);
            cbbolpoin = double.Parse(this.cbbolpoin.Text);
            cbpensil = double.Parse(this.cbpensil.Text);
            cbpenggaris = double.Parse(this.cbpenggaris.Text);
            cbpenghapus = double.Parse(this.cbpenghapus.Text);
            cbuang = double.Parse(this.cbuang.Text);

            hrgbukuTulis = cbbukuTulis * 5000;
            hrgbolpoin = cbbolpoin * 3500;
            hrgpensil = cbpensil * 2000;
            hrgpenggaris = cbpenggaris * 4000;
            hrgpenghapus = cbpenghapus * 1500;

            cbtotalBiaya = hrgbukuTulis + hrgbolpoin + hrgpensil + hrgpenggaris + hrgpenghapus;
            cbbiayaPajak = cbtotalBiaya * 0.1;

            cbtotalPembayaran = cbtotalBiaya + cbbiayaPajak;
            // Cek uang yang dibayarkan cukup atau tidak 
            if (cbuang < cbtotalPembayaran)
            {
                MessageBox.Show("Pembayaran Gagal, Uang anda tidak cukup harap masukkan uang kembali untuk melanjutkan transaksi !", "peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // keluar dari fungsi agar tidak dilanjutkan perhitungan kembali dll
            }

            cbkembalian = cbuang - cbtotalPembayaran;

            this.cbtotalBiaya.Text = "Rp." + cbtotalBiaya.ToString("N");
            this.cbtotalBiaya.Multiline = true;//biar tampil beberapa baris
            this.cbtotalBiaya.Text =
            "bukuTulis x" + cbbukuTulis + " = Rp " + (cbbukuTulis * 5000).ToString("N0") + "\r\n" +
            "bolpoin x" + cbbolpoin + " = Rp " + (cbbolpoin * 3500).ToString("N0") + "\r\n" +
            "pensil x" + cbpensil + " = Rp " + (cbpensil * 2000).ToString("N0") + "\r\n" +
            "penggaris x" + cbpenggaris + " = Rp " + (cbpenggaris * 4000).ToString("N0") + "\r\n" +
            "penghapus x" + cbpenghapus + " = Rp " + (cbpenghapus * 1500).ToString("N0") + "\r\n" +
            "\r\n" +
            "totalBiaya = Rp " + cbtotalBiaya.ToString("N0");


            this.cbbiayaPajak.Text = "Rp." + cbbiayaPajak.ToString("N");
            this.cbtotalPembayaran.Text = "Rp." + cbtotalPembayaran.ToString("N");
            this.cbkembalian.Text = "Rp." + cbkembalian.ToString("N");


            // --- Tambahkan pesan pembayaran berhasil ---
            MessageBox.Show("Pembayaran Berhasil !", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void biayaPajak_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void totalBiaya_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteData_Click(object sender, EventArgs e)
        {
            // Kosongkan semua combobox input
            cbbukuTulis.Text = "";
            cbbolpoin.Text = "";
            cbpensil.Text = "";
            cbpenggaris.Text = "";
            cbpenghapus.Text = "";
            cbuang.Text = "";

            // Kosongkan semua textbox output
            cbtotalBiaya.Text = "";
            cbbiayaPajak.Text = "";
            cbtotalPembayaran.Text = "";
            cbkembalian.Text = "";

            // Optional: Set fokus ke combobox dan textbox input
            cbbukuTulis.Focus();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Membuat instance Form1 (menu utama)
            Form1 form1 = new Form1();
            // Menampilkan Form1
            form1.Show();
            // Menutup form3 saat ini
            this.Close();
        }

        private void cbuang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
