using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rostelecom
{
    public partial class MACADD : Form
    {
        public MACADD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection())
            using (MySqlCommand cmd = new MySqlCommand())
            {
                conn.ConnectionString = "server=enkavzg1.beget.tech;user=enkavzg1_isp932 ;database=enkavzg1_isp932;password=ThLT8%c&;";
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO `Ilya_Nikitin_932` (`ID`, `Name`, `View`, `MAC`) VALUES (NULL, @name, @view, @mac)";
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@view", textBox2.Text);
                cmd.Parameters.AddWithValue("@mac", textBox3.Text);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                MessageBox.Show("Данные внесены");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectString = "server=enkavzg1.beget.tech;user=enkavzg1_isp932 ;database=enkavzg1_isp932;password=ThLT8%c&;";

            MySqlConnection myConnection = new MySqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT * FROM `Ilya_Nikitin_932`";

            MySqlCommand command = new MySqlCommand(query, myConnection);

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            MessageBox.Show("Таблица очищена");
        }
    }
}
