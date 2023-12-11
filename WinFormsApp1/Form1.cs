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
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp1
{
    public partial class auth : Form
    {
        DB database = new DB();
        public auth()
        {
            InitializeComponent();
            pass.UseSystemPasswordChar = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void passvis_CheckedChanged(object sender, EventArgs e)
        {
            if (passvis.Checked)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = login.Text;
            var passwordUser = pass.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT * FROM [Users] WHERE UserLogin = '{loginUser}' and UserPassword = '{passwordUser}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                string query = $"SELECT * FROM [Users]";
                SqlCommand command1 = new SqlCommand(querystring, database.getConnection());

                adapter.SelectCommand = command1;
                adapter.Fill(dt);
                string role = dt.Rows[0]["UserRole"].ToString();

                switch (role)
                {
                    case "1":
                        {
                            Form3 f3 = new Form3();
                            f3.ShowDialog();
                            this.Close();
                            break;
                        }
                    case "2":
                        {
                            Form2 f2 = new Form2();
                            f2.ShowDialog();
                            this.Close();
                            break;
                        }
                    case "3":
                        {
                            Form4 f4 = new Form4();
                            f4.ShowDialog();
                            this.Close();
                            break;
                        }
                    default:
                        {
                            break;
                        }

                }
            }
            else
                MessageBox.Show("Такого аккаунта не сущевствует", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}