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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace demoTest1
{
    public partial class Zakazchik : Form
    {
        int userID;
        public Zakazchik(int id)
        {
            InitializeComponent();
            userID = id;
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = Krimzon; Initial Catalog = db_demo; Integrated Security = True");

        private void Zakazchik_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"select * from request where clientID = {userID}", sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sqlConnection.Close();
        }

        private void MastButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand($"update request set carModel = '{textBox1.Text}', problemDescryption = '{textBox2.Text}' where requestID = {label1.Text}", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Заявка обновлена");
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            InsertRequest insertRequest = new InsertRequest(userID);
            insertRequest.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            label1.Text = row.Cells["requestID"].Value.ToString();
            textBox1.Text = row.Cells["carModel"].Value.ToString();
            textBox2.Text = row.Cells["problemDescryption"].Value.ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            this.Close();
        }
    }
}
