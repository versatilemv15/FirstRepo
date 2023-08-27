﻿using System;
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
    public partial class AccountingYear : Form
    {
        public AccountingYear()
        {
            InitializeComponent();
            Display();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pavilion\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Display()
        {
            Con.Open();
            string Query = "select * from BankMS";
            SqlDataAdapter sda=new SqlDataAdapter(Query,Con);
            SqlCommandBuilder Builder=new SqlCommandBuilder(sda);
            var ds=new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource=ds.Tables[0];
            Con.Close();
        }
        private void SetYearBtn_Click(object sender, EventArgs e)
        {
            if(YearTb.Text=="" || CurrYearCB.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BankMS(Year,CurrentYear)values(@Year,@CurrYear)", Con);
                    cmd.Parameters.AddWithValue("@Year", YearTb.Text);
                     cmd.Parameters.AddWithValue("@CurrYear", CurrYearCB.SelectedItem.ToString());
                   cmd.ExecuteNonQuery();
                    MessageBox.Show("Year Added!!");
                    Con.Close();
                    Display();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
