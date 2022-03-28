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
    public partial class Бугалтер : Form
    {
        public Бугалтер()
        {
            InitializeComponent();
        }



        private void EditButton_Click_1(object sender, EventArgs e)
        {
            Editing Изменение = new Editing();
            Изменение.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Autorisation Авторизация = new Autorisation();
            Авторизация.Show();
            this.Hide();
        }

    }
}
