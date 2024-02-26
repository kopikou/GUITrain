using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            arrivalHour.Text = Properties.Settings.Default.arrivalHour2.ToString();
            arrivalMinute.Text = Properties.Settings.Default.arrivalMinute2.ToString();
            departHour.Text = Properties.Settings.Default.departHour2.ToString();
            departMinute.Text = Properties.Settings.Default.departMinute2.ToString();
            commingHour.Text = Properties.Settings.Default.commingHour2.ToString();
            commingMinute.Text = Properties.Settings.Default.commingMinute2.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int arrivalHour1, arrivalMinute1, departHour1, departMinute1, commingHour1, commingMinute1;
            try
            {
                arrivalHour1 = int.Parse(this.arrivalHour.Text);
                arrivalMinute1 = int.Parse(this.arrivalMinute.Text);
                departHour1 = int.Parse(this.departHour.Text);
                departMinute1 = int.Parse(this.departMinute.Text);
                commingHour1 = int.Parse(this.commingHour.Text);
                commingMinute1 = int.Parse(this.commingMinute.Text);
            }
            catch (FormatException)
            {
                return;
            }

            Properties.Settings.Default.arrivalHour2 = arrivalHour1;
            Properties.Settings.Default.arrivalMinute2 = arrivalMinute1;
            Properties.Settings.Default.departHour2 = departHour1;
            Properties.Settings.Default.departMinute2 = departMinute1;
            Properties.Settings.Default.commingHour2 = commingHour1;
            Properties.Settings.Default.commingMinute2 = commingMinute1;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.WillStay(arrivalHour1, arrivalMinute1, departHour1, departMinute1, commingHour1, commingMinute1));
        }
    }
    public class Logic
    {
        public static string WillStay(int arrivalHour, int arrivalMinute, int departHour, int departMinute, int commingHour, int commingMinute)
        {
            string outMessage = "";
            if (((arrivalHour < commingHour) || ((arrivalHour == commingHour) && (arrivalMinute <= commingMinute))) &&
                ((departHour > commingHour) || ((departHour == commingHour) && (departMinute > commingMinute))))
            {
                outMessage = "Поезд будет стоять на платформе";
            }
            else
            {
                outMessage = "Поезд не будет стоять на платформе";
            }
            return outMessage;
        }


    }
}
