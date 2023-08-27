namespace BankApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void SigninBtn_Click(object sender, EventArgs e)
        {
            if (isValid()) 
            { Home h = new Home();
                h.Show();
                this.Hide(); }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            richTextBox1.Clear();
        }

        private bool isValid()
        {
            if (richTextBox2.Text.TrimStart() == String.Empty)
            {
                MessageBox.Show("Enter Valid Username","Error");
                return false;
            }
            else if(richTextBox1.Text.TrimStart() == String.Empty)
            {
                MessageBox.Show("Enter Valid Password", "Error");
                return false;
            }
            return true;
        }
    }
}