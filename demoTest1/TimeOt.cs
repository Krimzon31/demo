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
    public partial class TimeOt : Form
    {
        public TimeOt()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = Krimzon; Initial Catalog = db_demo; Integrated Security = True");

        private void TimeOt_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"select * from request", sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sqlConnection.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Operator operatorF = new Operator();
            operatorF.Show();
            this.Close();
        }
    }
}
