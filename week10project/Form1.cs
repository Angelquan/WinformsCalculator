using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week10project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LBLGPA_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btntest_Click(object sender, EventArgs e)
        {
            double T1 = double.Parse(TxtT1.Text);
            double T2 = double.Parse(txtT2.Text);
            double totalTest = ((T1 + T2) / 2) * .40;
            lblTestAvg.Text = totalTest.ToString();


        }

        private void btnquiz_Click(object sender, EventArgs e)
        {
            double q1 = double.Parse(txtQ1.Text);
            double q2 = double.Parse(txtQ2.Text);
            double q3 = double.Parse(txtQ3.Text);

            double totalquiz = ((q1 + q2 + q3) / 3) * .30;
            lblQuizAvg.Text = totalquiz.ToString();

        }

        private void btnassignment_Click(object sender, EventArgs e)
        {
            double A1 = double.Parse(txtAsgnmt1.Text);
            double A2 = double.Parse(txtAsgnmt2.Text);
            double A3 = double.Parse(txtAsgnmt3.Text);
            double A4 = double.Parse(txtAsgnmt4.Text);
            double A5 = double.Parse(txtAsgnmt5.Text);

            double totalAssignment = ((A1 + A2 + A3 + A4 + A5) / 5) * .30;
            lblAsgnmentAvg.Text = totalAssignment.ToString();
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            double ta = double.Parse(lblTestAvg.Text);
            double qa = double.Parse(lblQuizAvg.Text);
            double aa = double.Parse(lblAsgnmentAvg.Text);

            double totalAverage = (ta + qa + aa);
            LBLGPA.Text = totalAverage.ToString();


        }
    }
    
}
