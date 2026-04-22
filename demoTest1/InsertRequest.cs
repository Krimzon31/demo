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
    public partial class InsertRequest : Form
    {
        int userId;
        public InsertRequest(int id )
        {
            InitializeComponent();
            userId = id;
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = Krimzon; Initial Catalog = db_demo; Integrated Security = True");

        private void InsertRequestButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Today;

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand($"insert into request(requestID, startDate, carType, carModel, problemDescryption, requestStatus, clientID) values({requestID()}, '{dateTime.ToString("d")}', '{typeBox.Text}', '{modelBox.Text}', '{descriptionBox.Text}', 'Новая заявка', {userId})", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Заявка добавлена добавлен");
        }
        private int requestID()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"select max(requestID) from request", sqlConnection);
            sqlDataAdapter.Fill(dt);

            int rec_id = Convert.ToInt32(dt.Rows[0][0]) + 1;

            return rec_id;
        }
    }
}
