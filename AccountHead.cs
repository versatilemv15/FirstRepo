using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankApp1
{
    public partial class AccountHead : Form
    {
        public AccountHead()
        {
            InitializeComponent();
            Display();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pavilion\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Display()
        {
            Con.Open();
            string Query = "select * from Account";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            AhTb.Text = "";
            AbTb.Text = "";

        }
            private void ExitBtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (AhTb.Text == "" || AbTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Account(AccountHead,Abbrevation)values(@Ah,@Ab)", Con);
                    cmd.Parameters.AddWithValue("@Ah", AhTb.Text);
                    cmd.Parameters.AddWithValue("@Ab", AbTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Head Added");
                    Con.Close();
                    Display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (AhTb.Text == "" || AbTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update Account set AccountHead=@Ah,Abbrevation=@Ab where Id=@IKey", Con);
                    cmd.Parameters.AddWithValue("@Ah", AhTb.Text);
                    cmd.Parameters.AddWithValue("@Ab", AbTb.Text);
                    cmd.Parameters.AddWithValue("@IKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Head Updated");
                    Con.Close();
                    Display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;
        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Account where Id=@IKey", Con);
                    cmd.Parameters.AddWithValue("@IKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cancelled");
                    Con.Close();
                    Reset();
                    Display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AhTb.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            AbTb.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            if (AhTb.Text=="")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                //Key=Convert.ToInt32(AccHeadCB.SelectedIndex);
            }
        }
    }
}
