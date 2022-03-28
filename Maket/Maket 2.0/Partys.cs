using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maket_2._0
{
    public partial class Partys : Form
    {
        public Partys()
        {
            InitializeComponent();
        }

        private void Partys_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Модульное_МД_Финал_1_0DataSet.Мероприятия". При необходимости она может быть перемещена или удалена.
            this.мероприятияTableAdapter.Fill(this._Модульное_МД_Финал_1_0DataSet.Мероприятия);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            мероприятияTableAdapter.Update(_Модульное_МД_Финал_1_0DataSet);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Editing Изменение = new Editing();
            Изменение.Show();
            this.Hide();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
