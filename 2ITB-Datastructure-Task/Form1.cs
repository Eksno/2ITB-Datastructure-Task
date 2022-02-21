namespace _2ITB_Datastructure_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Globals.addBasicCarBrands();
        }
    }
}