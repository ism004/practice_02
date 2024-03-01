using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace engtest
{
    public partial class Times : Form
    {
        Thread th;
        private static Times instance;
        public static Times Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new Times();
                return instance;
            }
        }
        public Times()
        {
            InitializeComponent();
        }

        private void Times_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void open(object obj)
        {
            Application.Run(new Times2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неправильный ответ", "Ошибка");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неправильный ответ", "Ошибка");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Время вышло!", "Информация", MessageBoxButtons.OK);
        }
        private void lbl_timer_Click(object sender, EventArgs e)
        {

        }
    }

}
