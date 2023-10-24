using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meczKoszykowki
{
    public partial class Form1 : Form
    {
        int counterTeam1=0,
            counterTeam2=0,
            resultTeam1,
            resultTeam2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1PointTeam2_Click(object sender, EventArgs e)
        {
            resultTeam2 = ++counterTeam2;
            lblResultTeam2.Text = resultTeam2.ToString();
        }

        private void btn2PointsTeam2_Click(object sender, EventArgs e)
        {
            resultTeam2 = counterTeam2 += 2;
            lblResultTeam2.Text = resultTeam2.ToString();
        }

        private void btn1PointTeam1_Click(object sender, EventArgs e)
        {
            resultTeam1 = ++counterTeam1;
            lblResultTeam1.Text = resultTeam1.ToString();
        }

        private void btn2PointsTeam1_Click(object sender, EventArgs e)
        {
            resultTeam1 = counterTeam1 += 2;
            lblResultTeam1.Text = resultTeam1.ToString();
        }
    }
}
