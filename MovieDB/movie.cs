using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieDB
{
    public partial class movie : Form
    {
        public static string ConnectionString = "Data Source=DESKTOP-RI4HUJJ;Initial Catalog=moviedb;Integrated Security=True";
        SqlConnection sqlCon = new SqlConnection(ConnectionString);
        public static string comp_id_old;
        public movie()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            sqlCon.Open();
            string q = "Select * from moviedata";
            SqlDataAdapter sqlDa = new SqlDataAdapter(q, sqlCon);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            sqlCon.Close();
            movie_grid.DataSource = dtbl;
        }

        private void Movie_Load(object sender, EventArgs e)
        {

        }

        private void Movie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into moviedata (name,lead_actor,lead_actress,year,director_name) values ('" +name_txt.Text +"','" +lead_actor_txt.Text + "','" + lead_actress_txt.Text + "'," + Convert.ToInt32(year_txt.Text) + ",'" + director_txt.Text + "');";
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Inserted Successfully.");
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry!Couldn't insert.");
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                string q = "select * from moviedata where lead_actor='" + search_btn_txt.Text + "';";
                SqlDataAdapter sqlDa = new SqlDataAdapter(q, sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                movie_grid.DataSource = dtbl;
            }
            catch (Exception)
            {
                MessageBox.Show("Data not found.");
            }
        }
    }
}
