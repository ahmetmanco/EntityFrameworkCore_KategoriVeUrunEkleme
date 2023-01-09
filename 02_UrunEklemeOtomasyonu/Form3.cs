using _02_UrunEklemeOtomasyonu.Context;
using _02_UrunEklemeOtomasyonu.Entities;
using Microsoft.EntityFrameworkCore;
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
    public partial class Form3 : Form
    {
        private Form2 _frm;
        public Form3(Form2 frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        ProjectContext context;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.Urunler.Add(
           new Product()
           {
            Name = txtUrunAdi.Text,
            UnitPrice = birimFiyat.Value,
            Stock = (short)stok.Value,
            CategoryId = Convert.ToInt32(cmbKategoriAdi.SelectedValue),
            IsActive = true,
            AddedDate = DateTime.Now
           }
        );
    

            context.SaveChanges();
            listGuncelle();
            temizle();
        }

        private void temizle()
        {
            foreach(var item in this.groupBox1.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
                if(item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }
                if(item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int urunId = Convert.ToInt32(listeUrunler.SelectedItems[0].SubItems[0].Text);
            Product product = context.Urunler.Where(urunl => urunl.Id == urunId).FirstOrDefault();
            product.Name = txtUrunAdi.Text;
            product.UnitPrice = birimFiyat.Value;
            product.Stock = Convert.ToInt16(stok.Value);
            context.SaveChanges();



            listGuncelle();
            
        }

        private void kategoriCombobaxDoldur()
        {
           List<Category> categories = context.Kategoriler.Where(x=>x.IsActive).ToList();
            cmbKategoriAdi.DataSource= categories;
            cmbKategoriAdi.DisplayMember= "Name";
            cmbKategoriAdi.ValueMember = "Id";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Product product = context.Urunler.Find(Id);
            if (Id != null)
            {
                context.Urunler.Remove(product);
                //MessageBox.Show("Seçim Yapın!");
            }
            context.SaveChanges();
            Id = -1;
            listGuncelle();
        }

        private void listGuncelle()
        {
            List<Product>urunler = context.Urunler.Include("Category").ToList();

            listeUrunler.Items.Clear();

            foreach(Product urun in urunler)
            {
                ListViewItem list = new ListViewItem(urun.Id.ToString());
      
                list.SubItems.Add(urun.Name);
                list.SubItems.Add(urun.Category.Name);
                list.SubItems.Add(urun.UnitPrice.ToString());
                list.SubItems.Add(urun.Stock.ToString());
                list.SubItems.Add(urun.AddedDate.ToString());

               listeUrunler.Items.Add(list);
            }
        }

        private void btnKategoriEklemeEkranı_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();
            
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            context= new ProjectContext();
            listGuncelle();
            kategoriCombobaxDoldur();

        }
        int Id = -1;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Category category = new Category();
            foreach (ListViewItem ıtem in listeUrunler.SelectedItems)
            {
                Id = int.Parse(ıtem.SubItems[0].Text);
                txtUrunAdi.Text = ıtem.SubItems[1].Text;
                cmbKategoriAdi.Text = ıtem.SubItems[2].Text;
                birimFiyat.Value = Convert.ToDecimal(ıtem.SubItems[3].Text);
                stok.Value = Convert.ToDecimal(ıtem.SubItems[4].Text);
            }

        }
    }
}
