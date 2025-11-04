namespace Timer
{
    public partial class Form1 : Form
    {
        int ticks;

        int time;

        int secs;
        int mins;
        int hours;

        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            //label2.Text = ticks.ToString();
            this.Text = ticks.ToString();
            if (int.Parse(ticks.ToString()) == time)
            {
                timer1.Stop();
                notifyIcon1.ShowBalloonTip(8000, "Timer", "Times Up !!!", ToolTipIcon.Info);
                ticks = 0;
                time = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (secs == 0 && mins == 0 && hours == 0)
            {
                MessageBox.Show("Please Enter Parameters !!!");
            }
            else {
                time = hours * 3600 + mins * 60 + secs;
                timer1.Start();
            }

                
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = sender as NumericUpDown;
            secs = (int)nud.Value;

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = sender as NumericUpDown;
            hours = (int)nud.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = sender as NumericUpDown;
            mins = (int)nud.Value;
        }

        private void notifyIcon1_BalloonTipShown(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Text = "Timer";
            ticks = 0;
            time = 0;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
        }
    }
}
