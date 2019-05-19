using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace paramsAND2forms
{
    public partial class ScoreForm : Form
    {
        userScore user;
        public ScoreForm()
        {
            InitializeComponent();
        }

        public ScoreForm(userScore s) : this()
        {
            user = s;
        }
        private void buttonSaveXml_Click(object sender, EventArgs e)
        {

            //сериализация 
            labelBefoSave.Text = user.ToString();
            XmlSerializer formatter = new XmlSerializer(typeof(userScore));
            using (FileStream fs = new FileStream("score.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, user);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // десериализация
            XmlSerializer formatter = new XmlSerializer(typeof(userScore));
            FileStream fs = new FileStream("score.xml", FileMode.OpenOrCreate);
            userScore newuser = (userScore)formatter.Deserialize(fs);
            labelAfterSave.Text = newuser.ToString();
            fs.Close();
        }

        
    }
}
