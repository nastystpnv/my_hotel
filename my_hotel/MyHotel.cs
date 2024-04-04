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
using NLog;
namespace my_hotel
{
    public partial class Form1 : Form
    {
        Logger _logger;
        string[,] guests = new string[5, 7];
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            _logger = LogManager.GetLogger("simple");
            StreamReader n = new StreamReader("guests.txt");
            for (int i = 0; i < 4; i++)
            {
                guests[i, 0] = n.ReadLine();
                guests[i, 1] = n.ReadLine();
                guests[i, 2] = n.ReadLine();
                guests[i, 3] = n.ReadLine();
                guests[i, 4] = n.ReadLine();
                guests[i, 5] = n.ReadLine();
                guests[i, 6] = n.ReadLine();
                n.ReadLine();
            }
             
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                guestsListBox.Items.Clear();
                for (int i = 0; i<4; i++)
                {
                    if (guests [i,3] == "зарезервировано")
                    {
                        guestsListBox.Items.Add(guests[i, 1]);
                    }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                guestsListBox.Items.Clear();
                for (int i = 0; i < 4; i++)
                {
                    if (guests[i, 3] == "свободно")
                    {
                        guestsListBox.Items.Add(guests[i, 1]);
                    }
                }
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                guestsListBox.Items.Clear();
                for (int i = 0; i < 4; i++)
                {
                    if (guests[i, 3] == "занято")
                    {
                        guestsListBox.Items.Add(guests[i, 1]);
                    }
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                guestsListBox.Items.Clear();
                for (int i = 0; i < 4; i++)
                {
                    if (guests[i, 3] == "выписываются")
                    {
                        guestsListBox.Items.Add(guests[i, 1]);
                    }
                    _logger.Debug("Проверка NLog");
                    _logger.Error("На случай ошибки");
                }
            }
        }

        private void guestsListBox_DoubleClick(object sender, EventArgs e)
        {
            string a = guestsListBox.SelectedItem.ToString();
            for (int i = 0; i < 4; i++)
            {
                if (guests[i,1] == a)
                {
                    fioLabel.Text = a;
                    numberLabel.Text = guests[i, 0];
                    statusComboBox.Text = guests[i, 3];
                    zaezdLabel.Text = guests[i, 5];
                    viezdLabel.Text = guests[i, 6];
                    pictureBox1.Image = new Bitmap(guests[i, 2]);
                }
            }
        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            card.Show();
        }

        private void guestsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
