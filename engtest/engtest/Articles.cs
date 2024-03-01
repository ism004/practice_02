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
    public partial class Articles : Form
    {
        Thread th;
        private static Articles instance;
        public static Articles Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new Articles();
                return instance;
            }
        }
        public Articles()
        {
            InitializeComponent();
        }

        private void Articles_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open(object obj)
        {
            Application.Run(new Articles2());
        }

        private void artTimer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Время вышло!", "Информация", MessageBoxButtons.OK);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неправильный ответ", "Ошибка");
        }
    }
}
