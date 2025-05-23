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
            //同期処理　messagebox.Showは同期関数
            MessageBox.Show("hello");

            buttonProperty.Text = "押された";
            buttonProperty.Left = 5;
            buttonProperty.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Left = button1.Left * 2;

            // 修正: buttonProperty に button1 を代入するだけに変更
            buttonProperty = button1;

            // 修正: 不正な代入を削除
            // buttonProperty = button1 = 2;

            button1.Top = button1.Top + 1; buttonProperty.Visible = true;
        }
    }
}
