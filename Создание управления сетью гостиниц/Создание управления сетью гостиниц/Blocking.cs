using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Создание_управления_сетью_гостиниц
{
    public partial class Blocking : Form
    {
        Form1 form1 = new Form1();
        public int timeLeft;
        public int indexator;
        public Blocking()
        {
            form1.Hide();
            InitializeComponent();
            //timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] splitter = label3.Text.Split(' ');
            timeLeft = Convert.ToInt32(splitter[0]);
            DB DataBase = new DB();
            DataBase.indexator = this.indexator;
            DataBase.Timer(timeLeft);
            form1.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                label3.Text = timeLeft + " секунд";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timer1.Enabled = false;
                //label3.Text = "Time's up!";
                label2.Text = "Время блокировки истекло";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] splitter = label3.Text.Split(' ');
            timeLeft = Convert.ToInt32(splitter[0]);
            DB DataBase = new DB();
            DataBase.indexator = this.indexator;
            DataBase.Timer(timeLeft);
            Application.Exit();
        }

        public void Indexator(int index)
        {
            indexator = index;
        }
        private void Blocking_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label3.Text = timeLeft + " секунд";
            //timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
