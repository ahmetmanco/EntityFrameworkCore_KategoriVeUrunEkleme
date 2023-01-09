using _02_UrunEklemeOtomasyonu.Context;
using _02_UrunEklemeOtomasyonu.Entities;

namespace _02_UrunEklemeOtomasyonu
{
    public partial class Form1 : Form
    {
        ProjectContext Context;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Context = new ProjectContext();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
   
            var user = Context.AppUser.Where(user=>user.UserName==txtKullaniciAdi.Text && user.Password == txtParola.Text).FirstOrDefault();

            if (string.IsNullOrEmpty(txtKullaniciAdi.Text)&& string.IsNullOrEmpty(txtParola.Text))
                MessageBox.Show("Kullanýcý adý veya parola boþ olamaz");

            else if (user != null)
            {
                Form2 frm= new Form2();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya parola yanlýþ");
            }
            
            
            
        }
    }
}