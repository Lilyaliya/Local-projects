using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Создание_управления_сетью_гостиниц
{
    public partial class Form1 : Form
    {
        public int iterator=0;
        public Form1()
        {
            InitializeComponent();
            this.Password.AutoSize = false;
            this.Password.Size = new Size(this.Password.Size.Width, this.Login.Size.Height);
            this.Password.UseSystemPasswordChar = true;
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point coords;

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - coords.X;
                Top += e.Y - coords.Y;
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            coords = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB DataBase = new DB();
            DataBase.ChangeDB();
            if (Login.Text!="" && Password.Text != "")
            {
                if (DataBase.IsValid(Login.Text, Password.Text)&&DataBase.IsTrue(DataBase.Iterator(Login.Text)))
                {
                    if (DataBase.Key(Login.Text, Password.Text).role == "Manager")
                    { new OpenClose(new Manager(), this); }
                    else if (DataBase.Key(Login.Text, Password.Text).reason !=""&&DataBase.Key(Login.Text, Password.Text).reason != null)
                    {
                        MessageBox.Show("Вы были заблокированы Управляющим по следующей причине:\n"+DataBase.Key(Login.Text, Password.Text).reason,"Заблокирован", MessageBoxButtons.OKCancel);
                    }
                    else
                    { new OpenClose(new Administrator(), this, DataBase.Key(Login.Text, Password.Text)); }
                }
                else
                {
                    
                    int index=DataBase.Iterator(Login.Text);
                    if (index == -1)
                    {
                        MessageBox.Show("Такого пользователя не существует. Убедитесь, что вы ввели верные логин и пароль");
                        return;
                    }
                    DataBase.Updating(index, this);
                }
            }
            else MessageBox.Show("Пожалуйста, заполните поля пароля и логина");
            
        }

        public void ShMsg(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
