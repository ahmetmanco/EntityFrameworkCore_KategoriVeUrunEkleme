using _02_UrunEklemeOtomasyonu.Context;
using _02_UrunEklemeOtomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_UrunEklemeOtomasyonu
{
    public partial class Form2 : Form
    {
        ProjectContext context;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
           context.Kategoriler.Add(new Category() { Name=txtKategoriAdi.Text,Description=txtAciklama.Text});
            context.SaveChanges();
           // context.Urunler.Add(new Product() {})
            gridDoldur();

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            this.Hide();
            form3.Show();
            //gridDoldur();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            context = new ProjectContext();
           
            gridDoldur();
        }

        private void gridDoldur()
        {
            dataGridView1.DataSource = context.Kategoriler.ToList();
        }
    }
}
