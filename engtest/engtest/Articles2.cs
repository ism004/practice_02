using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engtest
{
    public partial class Articles2 : Form
    {
        Thread th;
        public Articles2()
        {
            InitializeComponent();
        }

        private void Articles2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open(object obj)
        {
            Application.Run(new Articles3());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Время вышло!", "Информация", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неправильный ответ", "Ошибка");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неправильный ответ", "Ошибка");
        }
    }
}
