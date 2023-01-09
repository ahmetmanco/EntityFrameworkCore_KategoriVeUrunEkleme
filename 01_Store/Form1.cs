namespace _01_Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProjectContext context = new ProjectContext();
            context.Dukkanlar.Add(new Store() { Name = "MediaMarkt" });
            context.Urunler.Add(new Product() { Name = "Elektronik", StroId = 1 });
            context.SaveChanges();
        }
    }
}