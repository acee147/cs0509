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
            buttonProperty.Left = 5;
            buttonProperty.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Left = button1.Left * 2;

            // �C��: buttonProperty �� button1 �������邾���ɕύX
            buttonProperty = button1;

            // �C��: �s���ȑ�����폜
            // buttonProperty = button1 = 2;

            button1.Top = button1.Top + 1; buttonProperty.Visible = true;
        }
    }
}
