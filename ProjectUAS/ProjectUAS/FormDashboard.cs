using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUAS
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void footer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            FormHome frmHome = new FormHome();
            frmHome.TopLevel = false;
            frmHome.AutoScroll = true;
            this.konten.Controls.Clear();
            this.konten.Controls.Add(frmHome);
            frmHome.Show();
            lblActiveMenu.Text = "Home";
        }

        private void labelTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void labelTransaksi_Click_1(object sender, EventArgs e)
        {
            FormTransaksi frmTransaksi = new FormTransaksi();
            frmTransaksi.TopLevel = false;
            frmTransaksi.AutoScroll = true;
            this.konten.Controls.Clear();
            this.konten.Controls.Add(frmTransaksi);
            frmTransaksi.Show();
            lblActiveMenu.Text = "Transaksi";
        }

        private void labelDataBarang_Click(object sender, EventArgs e)
        {
            FormDataBarang frmDataBarang = new FormDataBarang();
            frmDataBarang.TopLevel = false;
            frmDataBarang.AutoScroll = true;
            this.konten.Controls.Clear();
            this.konten.Controls.Add(frmDataBarang);
            frmDataBarang.Show();
            lblActiveMenu.Text = "DataBarang";
        }

        private void labelLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan frmLaporan = new FormLaporan();
            frmLaporan.TopLevel = false;
            frmLaporan.AutoScroll = true;
            this.konten.Controls.Clear();
            this.konten.Controls.Add(frmLaporan);
            frmLaporan.Show();
            lblActiveMenu.Text = "Laporan";
        }

        private void labelKeluar_Click(object sender, EventArgs e)
        {
            FormHome frmHome = new FormHome();
            frmHome.TopLevel = false;
            frmHome.AutoScroll = true;
            this.konten.Controls.Clear();
            this.konten.Controls.Add(frmHome);
            frmHome.Show();
            lblActiveMenu.Text = "Home";
        }
    }
}
