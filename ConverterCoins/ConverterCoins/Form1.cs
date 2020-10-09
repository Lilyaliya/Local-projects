using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterCoins
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, to;
            
            if ((textBox1.Text!=null)&&(listBox1.SelectedItem.ToString()!=null)&&(listBox1.SelectedItem.ToString()!=null))
            {
                from = listBox1.SelectedItem.ToString();
                to = listBox2.SelectedItem.ToString();
                webBrowser1.Navigate("https://www.google.ru/search?q="+textBox1.Text+" " + from+" %D0%B2 "+to);
            }
        }
    }
}
