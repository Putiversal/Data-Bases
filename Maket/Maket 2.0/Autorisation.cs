using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Maket_2._0
{
    public partial class Autorisation : Form
    {
        public Autorisation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Admin" && passField.Text == "123")
            {
                Админ Admin = new Админ();
                Admin.Show();
                this.Hide();
            }
            else if (comboBox1.Text == "Buhgalter" && passField.Text == "456")
            {
                Бугалтер Bugalter = new Бугалтер();
                Bugalter.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль.", "Ошибка", MessageBoxButtons.OK);
            }


        }
    }
}
