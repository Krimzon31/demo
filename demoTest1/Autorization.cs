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
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = Krimzon; Initial Catalog = db_demo; Integrated Security = True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

        private void autButton_Click(object sender, EventArgs e)
        {

            string login= textBox1.Text.ToString();
            string pass = textBox2.Text.ToString();


            DataTable dt = new DataTable();
            sqlConnection.Open();
            string commandStr = $"select userID, type from users where login = '{login}' and password = '{pass}'";
            SqlCommand sqlCommand = new SqlCommand(commandStr, sqlConnection);

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dt);

            string role = "";

            try
            {
                role = Convert.ToString(dt.Rows[0][1]);

                switch(role)
                {
                    case "Оператор":
                        Operator operatorF = new Operator();
                        operatorF.Show();
                        MessageBox.Show("Оператор авторизирован");
                        break;

                    case "Автомеханик":
                        int mastID = Convert.ToInt32(dt.Rows[0][0]);
                        Master master = new Master(mastID);
                        master.Show();
                        MessageBox.Show("Механник авторизирован");
                        break;

                    case "Заказчик":
                        int userId = Convert.ToInt32(dt.Rows[0][0]);
                        Zakazchik zakazchik = new Zakazchik(userId);
                        zakazchik.Show();
                        MessageBox.Show("Заказчик авторизирован");
                        break;

                    case "Менеджер":
                        Manager manager = new Manager();
                        manager.Show();
                        MessageBox.Show("Менеджер авторизирован");
                        break;
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
