using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kill_Stars
{
    public partial class nameKillStars : Form
    {
        public nameKillStars()
        {
            //Подключаю XAMPP
            string MySqlCon = "server = localhost;user = root; database = killer; password = ";
            MySqlConnection mySqlConnection = new MySqlConnection("");
            //Вывод слов для проверки подключения
            try 
            {
                mySqlConnection.Open();
                MessageBox.Show("БАЗА ДАННЫХ РАБОТАЕТ БЛЯТЬ");
            }
            //Обработчик исключений
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Закрыть потоки и файлы
            finally { mySqlConnection.Close(); }

            InitializeComponent();

        }

        //Передвижение главного окна
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
