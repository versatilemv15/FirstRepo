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
    public partial class OpeningBalance : Form
    {
        public OpeningBalance()
        {
            InitializeComponent();
            Display();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pavilion\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Reset()
        {
            AccHeadCB.SelectedIndex = -1;
            QCb.SelectedIndex = -1;
        }
        private void Display()
        {
            Con.Open();
            string Query = "select * from OpTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (AccHeadCB.SelectedIndex == -1 || QCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into OpTable(AccountHead,Quantity)values(@Ah,@Q)", Con);
                    cmd.Parameters.AddWithValue("@Ah", AccHeadCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Q", QCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Head Quantity Added");
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
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if(Key==0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from OpTable where Id=@IKey", Con);
                    cmd.Parameters.AddWithValue("@IKey",Key);
                    
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
            AccHeadCB.SelectedItem = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            QCb.SelectedItem = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            if (AccHeadCB.SelectedIndex == -1)
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                //Key=Convert.ToInt32(AccHeadCB.SelectedIndex);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
