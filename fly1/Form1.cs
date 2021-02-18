using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fly1
{
    public partial class Form1 : Form
    {
        double t, x0, y0, v0, cosa, sina;
        const double g = 9.81;
        const double dt = 0.1;
        public int time_now = 0;
        public int m = 0;
        string timer;

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer_bool = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer_bool = true;
        }

        public int s;
        public bool timer_bool = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                chart.Series[0].Points.Clear();
                t = 0;
                x0 = 0;
                y0 = (double)forHeight.Value;
                v0 = (double)forSpeed.Value;
                double a = (double)forAngle.Value * Math.PI / 180;
                cosa = Math.Cos(a);
                sina = Math.Sin(a);
                chart.Series[0].Points.AddXY(x0, y0);
                timer1.Start();
                timer_bool = true;
                double H = y0 + (v0 * v0 * sina * sina) / (2 * g);
                double T = ((v0 * sina) + (Math.Sqrt((v0 * v0 * sina * sina) + (2 * g * H)))) / g;
                double S = v0 * T * cosa;
                chart.ChartAreas[0].AxisX.Maximum = S;
                chart.ChartAreas[0].AxisY.Maximum = H;
                timer = "00:00";
                time_now = 0;
                m = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            double x = x0 + v0 * cosa * t;
            double y = y0 + v0 * sina * t - g * t * t / 2;
            chart.Series[0].Points.AddXY(x, y);
            if (timer_bool == true)
            {
                time_now += timer1.Interval;
                s = time_now / 1000;
                if (m > 0)
                {
                    s = Math.Abs(m * 60 - s);
                }
                if (s > 0 && s % 60 == 0)
                {
                    s = 0;
                    m += 1;
                }
                timer = "";

                if (m < 10)
                {
                    timer += "0" + m.ToString();
                }
                else
                {
                    timer += m.ToString();
                }

                timer += ":";

                if (s < 10)
                {
                    timer += "0" + s.ToString();
                }
                else
                {
                    timer += s.ToString();
                }
                time.Text = timer;
            }
            if (y <= 0)
            {
                timer1.Stop();
                timer_bool = false;
                timer = "00:00";
                time_now = 0;
                m = 0;
            }
        }
    }
}
