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
using MySql.Data.MySqlClient;

namespace git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

       

        public static MySqlConnection connexion()
        {
            string host = "localHost";
            int port = 3307;
            string database = "git";
            string username = "root";
            string password = "";
            string SSLmode = "";

            DataSet ds = new DataSet();

            string connString = "Server" + host + ";Database" + database +
                ";port" + port + ";User id=" + password + "SSL MODE=" + SSLmode;

            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection connect = connexion();
            SqlCommand com = new SqlCommand();
            MySqlDataAdapter da;

            try
            {
                List<classes> Classe = new List<classes>();

                connect.Open();
                MySqlCommand cmd = connect.CreateCommand();

                cmd.CommandText = "Select * from classes";
                MySqlDataAdapter emp = cmd.ExecuteReader();
                while (emp.Read))
                {
                    Classe maClasse = new Classes();
                    maClasse.id = emp.GetInt32("id");
                    maClasse.Numero = emp.GetString("Numéro");
                    Classe.Add(maClasse);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
