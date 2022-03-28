using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Модульное_МД_Финал_1_0DataSet.Запрос". При необходимости она может быть перемещена или удалена.
            this.запросTableAdapter.Fill(this._Модульное_МД_Финал_1_0DataSet.Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Модульное_МД_Финал_1_0DataSet.Проект". При необходимости она может быть перемещена или удалена.
            this.проектTableAdapter.Fill(this._Модульное_МД_Финал_1_0DataSet.Проект);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Модульное_МД_Финал_1_0DataSet.Офисы". При необходимости она может быть перемещена или удалена.
            this.офисыTableAdapter.Fill(this._Модульное_МД_Финал_1_0DataSet.Офисы);

        }
    }
}
