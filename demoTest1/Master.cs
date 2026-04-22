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
    public partial class Master : Form
    {
        int mastId;
        public Master(int id)
        {
            InitializeComponent();
            this.mastId = id;
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = Krimzon; Initial Catalog = db_demo; Integrated Security = True");
        
        private void Master_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"select * from request where masterID = {mastId}", sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sqlConnection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            label1.Text = row.Cells["requestID"].Value.ToString();
        }

        private void StatysButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string status = comboBox1.Text;
            SqlCommand cmd = new SqlCommand($"update request set requestStatus = '{status}' where requestID = {label1.Text}", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Статус обновлён");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            this.Close();
        }

        private void InsertComButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string status = comboBox1.Text;
            SqlCommand cmd = new SqlCommand($"insert into com values({comID()}, '{textBox1.Text}', {mastId}, {label1.Text})", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Комментарий добавлен");
        }

        private int comID()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"select max(commentID) from com", sqlConnection);
            sqlDataAdapter.Fill(dt);

            int com_id = Convert.ToInt32(dt.Rows[0][0]) + 1;

            return com_id;
        }
    }
}
