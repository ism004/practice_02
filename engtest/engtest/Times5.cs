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
    public partial class Times5 : Form
    {
        private static Times5 instance;
        public static Times5 Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new Times5();
                return instance;
            }

        }
        public Times5()
        {
            InitializeComponent();
        }

        private void Times5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Всё верно!!!", "Поздравляем!");
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Время вышло!", "Информация", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неправильный ответ", "Ошибка");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неправильный ответ", "Ошибка");
        }
    }
}
