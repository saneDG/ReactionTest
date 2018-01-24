using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        double duration1 = 0;
        double duration2 = 0;
        int bestTime = 10;
        double average;
        double calculator;
        double add;


        public Form1()
        {
            InitializeComponent();
        }

        private void ready3_Click(object sender, EventArgs e)
        {

        }

        private void reactionButton_Click(object sender, EventArgs e)
        {
            reactionButton.Text = "WOW";
            timer1.Stop();

            if (duration1 < bestTime)
            {
                personalBest.Text = timer.Text;
                duration1 = bestTime;
            }
            if (go.Text == "X")
            {
                duration1 = 0;
                duration2 = 0;
                timer2.Stop();
                timer1.Stop();
                ready1.Text = "X";
                ready2.Text = "X";
                ready3.Text = "X";
                ready4.Text = "X";
                go.Text = "X";
                reactionButton.Text = "fail XD";
                timer.Text = "0.000";
                personalBest.Text = "dont cheat";

            }
        }

        private void timer_Click(object sender, EventArgs e)
        {

        }

        private void ready1_Click(object sender, EventArgs e)
        {

        }

        private void ready2_Click(object sender, EventArgs e)
        {

        }

        private void go_Click(object sender, EventArgs e)
        {

        }

        private void ready4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            duration1 = duration1 + 0.001;
            timer.Text = duration1.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            duration2++;

            if (timer2.Enabled == true)
            {
                if (duration2 == 1)
                {
                    ready1.Text = "O";
                }
                if (duration2 == 2)
                {
                    ready2.Text = "O";
                }
                if (duration2 == 3)
                {
                    ready3.Text = "O";
                }
                if (duration2 == 4)
                {
                    ready4.Text = "O";
                }
                if (duration2 > 6.20 && go.Text == "X")
                {
                    go.Text = "O";
                    timer1.Enabled = true;
                    timer1.Start();
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            calculator++;
            add = duration1 + add;
            average = (duration1 + add) / calculator;
            avgCount.Text = Convert.ToString(calculator);
            avgNumber.Text = Convert.ToString(average);
            duration1 = 0;
            duration2 = 0;
            timer2.Stop();
            ready1.Text = "X";
            ready2.Text = "X";
            ready3.Text = "X";
            ready4.Text = "X";
            go.Text = "X";
            reactionButton.Text = "READY";
            timer.Text = "0.000";
        }

        private void personalBest_Click(object sender, EventArgs e)
        {

        }

        private void PB_Click(object sender, EventArgs e)
        {

        }

        private void avgNumber_Click(object sender, EventArgs e)
        {

        }

        private void avgCount_Click(object sender, EventArgs e)
        {

        }
    }
}
