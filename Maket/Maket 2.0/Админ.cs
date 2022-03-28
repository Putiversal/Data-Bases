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
    public partial class Админ : Form
    {
        public Админ()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Autorisation Авторизация = new Autorisation();
            Авторизация.Show();
            this.Hide();
        }
    }
}
