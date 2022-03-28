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
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Модульное_МД_Финал_1_0DataSet.Проект". При необходимости она может быть перемещена или удалена.
            this.проектTableAdapter.Fill(this._Модульное_МД_Финал_1_0DataSet.Проект);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            проектTableAdapter.Update(_Модульное_МД_Финал_1_0DataSet);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Editing Изменение = new Editing();
            Изменение.Show();
            this.Hide();
        }
    }
}
