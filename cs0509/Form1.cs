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
            //���������@messagebox.Show�͓����֐�
            MessageBox.Show("hello");

            buttonProperty.Text = "�����ꂽ";
            buttonProperty.Left = 0;
            buttonProperty.Visible = true;
            
        }
    }
}
