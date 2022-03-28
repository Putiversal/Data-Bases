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
    public partial class Editing : Form
    {
        public Editing()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Модульное_МД_Финал_1_0DataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this._Модульное_МД_Финал_1_0DataSet.Персонал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Модульное_МД_Финал_1_0DataSet.Офисы". При необходимости она может быть перемещена или удалена.
            this.офисыTableAdapter.Fill(this._Модульное_МД_Финал_1_0DataSet.Офисы);

        }

        private void PersonalButton_Click(object sender, EventArgs e)
        {
            Personal Персонал = new Personal();
            Персонал.Show();
            this.Hide();
        }

        private void RequestsButton_Click(object sender, EventArgs e)
        {
            Requests Заказы = new Requests();
            Заказы.Show();
            this.Hide();
        }

        private void PartyButton_Click(object sender, EventArgs e)
        {
            Partys Мероприятия = new Partys();
            Мероприятия.Show();
            this.Hide();
        }

        private void OfficesButton_Click(object sender, EventArgs e)
        {
            Offices Офисы = new Offices();
            Офисы.Show();
            this.Hide();
        }

        private void ProjectsButton_Click(object sender, EventArgs e)
        {
            Projects Проекты = new Projects();
            Проекты.Show();
            this.Hide();
        }

        private void GroupsButton_Click(object sender, EventArgs e)
        {
            Groups Группы = new Groups();
            Группы.Show();
            this.Hide();
        }

        private void TransportButton_Click(object sender, EventArgs e)
        {
            Transport Транспорт = new Transport();
            Транспорт.Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Бугалтер Bugalter = new Бугалтер();
            Bugalter.Show();
            this.Hide();
        }
    }
}
