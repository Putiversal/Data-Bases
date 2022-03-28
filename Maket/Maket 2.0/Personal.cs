using Microsoft.ReportingServices.Diagnostics.Internal;
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

namespace Maket_2._0
{
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Модульное_МД_Финал_1_0DataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this._Модульное_МД_Финал_1_0DataSet.Персонал);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            персоналTableAdapter.Update(_Модульное_МД_Финал_1_0DataSet);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Editing Изменение = new Editing();
            Изменение.Show();
            this.Hide();
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                SqlConnection connection = new SqlConnection("Data Source=C:\\study\\4 сем\\БД\\Maket\\_Модульное_МД_Финал_1.0.mdb");
                _Модульное_МД_Финал_1_0DataSet.Tables["Персонал"]?.Clear();

                string sql = "SELECT * FROM Персонал WHERE ФИО LIKE @name";
                string name = $"%{SearchBox.Text}%";

                using (var dataAdapter = new SqlDataAdapter(sql, connection))
                {
                    dataAdapter.SelectCommand.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
                    dataAdapter.Fill(_Модульное_МД_Финал_1_0DataSet, "Персонал");
                }

                dataGridView1.DataSource = _Модульное_МД_Финал_1_0DataSet.Tables["Персонал"];
            }
        }

    }
}
