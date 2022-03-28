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
    public partial class Offices : Form
    {
        public Offices()
        {
            InitializeComponent();
        }

        private void Offices_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Модульное_МД_Финал_1_0DataSet.Офисы". При необходимости она может быть перемещена или удалена.
            this.офисыTableAdapter.Fill(this._Модульное_МД_Финал_1_0DataSet.Офисы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            офисыTableAdapter.Update(_Модульное_МД_Финал_1_0DataSet);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Editing Изменение = new Editing();
            Изменение.Show();
            this.Hide();
        }
    }
}
