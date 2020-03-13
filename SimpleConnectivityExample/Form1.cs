using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SimpleConnectivityExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            string strConnectionString;
            SqlConnection cnn;
            strConnectionString = @"Data Source=ROSS-COMPUTER\SQLEXPRESS; Database=SudoKubed; Integrated Security=true;";
            cnn = new SqlConnection(strConnectionString);
            cnn.Open();
            MessageBox.Show($"Connection state: {cnn.State}");
            cnn.Close();
        }
    }
}
