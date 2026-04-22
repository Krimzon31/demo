using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoTest1
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = Krimzon; Initial Catalog = db_demo; Integrated Security = True");


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            label1.Text = row.Cells["requestID"].Value.ToString();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            this.Close();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"select * from request", sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sqlConnection.Close();
        }

        private void MastButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string status = comboBox1.Text;
            SqlCommand cmd = new SqlCommand($"update request set masterID = {comboBox1.Text} where requestID = {label1.Text}", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Мастер назначен");
        }
    }
}
