using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KosishnevaAN.Sprint7.Project.V11
{
    public partial class FormMainPUSK_KAN : Form
    {
        public FormMainPUSK_KAN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
        }

        private void buttonSpravka_KAN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Raszrabochik raszrabochik = new Raszrabochik();
            raszrabochik.Show();
        }
    }
}
