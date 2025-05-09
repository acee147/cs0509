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
            buttonProperty.Left = 5;
            buttonProperty.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Left = button1.Left * 2;

            // C³: buttonProperty ‚É button1 ‚ğ‘ã“ü‚·‚é‚¾‚¯‚É•ÏX
            buttonProperty = button1;

            // C³: •s³‚È‘ã“ü‚ğíœ
            // buttonProperty = button1 = 2;

            button1.Top = button1.Top + 1; buttonProperty.Visible = true;
        }
    }
}
