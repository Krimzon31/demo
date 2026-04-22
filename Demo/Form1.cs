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
using SD = System.Data;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ConnectionClass connectionClass = new ConnectionClass();
        private void Form1_Load(object sender, EventArgs e)
        {
           /* // TODO: данная строка кода позволяет загрузить данные в таблицу "demoDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.demoDataSet.Client);
            connectionClass.openConnection();

            SqlDataAdapter dataAdapter1 = new SqlDataAdapter("select * from Employee", connectionClass.GetConnection());
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter("select * from Client", connectionClass.GetConnection());
            SqlDataAdapter dataAdapter3 = new SqlDataAdapter("select * from Manager", connectionClass.GetConnection());
            SqlDataAdapter dataAdapter4 = new SqlDataAdapter("select * from Request", connectionClass.GetConnection());
            SqlDataAdapter dataAdapter5 = new SqlDataAdapter("select * from Request_Specialist", connectionClass.GetConnection());
            SqlDataAdapter dataAdapter6 = new SqlDataAdapter("select * from Specialist", connectionClass.GetConnection());


            SD.DataSet db1 = new SD.DataSet();
            SD.DataSet db2 = new SD.DataSet();
            SD.DataSet db3 = new SD.DataSet();
            SD.DataSet db4 = new SD.DataSet();
            SD.DataSet db5 = new SD.DataSet();
            SD.DataSet db6 = new SD.DataSet();

            dataAdapter1.Fill(db1);
            dataAdapter2.Fill(db2);
            dataAdapter3.Fill(db3);
            dataAdapter4.Fill(db4);
            dataAdapter5.Fill(db5);
            dataAdapter6.Fill(db6);

            dataGridView1.DataSource = db1.Tables[0];
            dataGridView2.DataSource = db2.Tables[0];
            dataGridView3.DataSource = db3.Tables[0];
            dataGridView4.DataSource = db4.Tables[0];
            dataGridView5.DataSource = db5.Tables[0];
            dataGridView6.DataSource = db6.Tables[0];

            connectionClass.closeConnection();
           */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
