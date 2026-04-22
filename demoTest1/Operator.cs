using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoTest1
{
    public partial class Operator : Form
    {
        public Operator()
        {
            InitializeComponent();
        }

        private void ComplOt_Click(object sender, EventArgs e)
        {
            CompOt compOt = new CompOt();
            compOt.Show();
            this.Close();
        }

        private void TypeOt_Click(object sender, EventArgs e)
        {
            TypeOtcs typeOt = new TypeOtcs();
            typeOt.Show();
            this.Close();
        }

        private void TimeOt_Click(object sender, EventArgs e)
        {
            TimeOt timeOt = new TimeOt();
            timeOt.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            this.Close();
        }
    }
}
