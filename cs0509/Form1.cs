namespace cs0509
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //“¯Šúˆ—@messagebox.Show‚Í“¯ŠúŠÖ”
            MessageBox.Show("hello");

            buttonProperty.Text = "‰Ÿ‚³‚ê‚½";
            buttonProperty.Left = 0;
            buttonProperty.Visible = true;
            
        }
    }
}
