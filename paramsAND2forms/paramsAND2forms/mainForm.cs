using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paramsAND2forms
{
    public partial class mainForm : Form
    {
        string userName;
        Random rnd = new Random();
        public mainForm()
        {
            InitializeComponent();
        }
        public mainForm(string name):this()
        {
            userName = name;
            this.Text = "Имя пользователя:" + userName;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = rnd.Next(10).ToString();
            label2.Text = rnd.Next(10).ToString();
            label3.Text = rnd.Next(10).ToString();

            labelSpend.Text = (Convert.ToInt32(labelSpend.Text) + 50).ToString();
            if (label1.Text == label2.Text && label2.Text == label3.Text)
                labelWin.Text = (Convert.ToInt32(labelWin.Text) + 50).ToString();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Точно хочешь выйти?", "Выход из программы", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
                
                
            }
            else
            {
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userScore user = new userScore(userName, Convert.ToInt32(labelSpend.Text), Convert.ToInt32(labelWin.Text));
            ScoreForm ff = new ScoreForm(user);
            ff.ShowDialog();
        }
    }
}
