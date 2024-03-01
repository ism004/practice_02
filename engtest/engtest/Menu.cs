using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engtest
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Times form2 = Times.Instance;
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Articles form2 = Articles.Instance;
            form2.Show();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите тип тестирования и выполните 5 заданий. Время на выполнение каждого задания = 15 секунд", "Инструкция");
        }
    }
}
