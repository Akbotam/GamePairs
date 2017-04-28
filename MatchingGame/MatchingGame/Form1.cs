using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
us

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        int score = 0; // Our scores
        Random Location = new Random();
        List<int> X = new List<int>();
        List<int> Y = new List<int>();
        bool again = false;
        public Bitmap btm;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            btm = new Bitmap(133, 181);
            btm = new Bitmap(@"C:\Users\Андрей\GamePairs\fruits\Card1.png");
            Card1.Image = btm;

            Card1.Image = Properties.Resources.Card1;
            DupCard1.Image = Properties.Resources.Card1;
            Card2.Image = Properties.Resources.card2;
            DupCard2.Image = Properties.Resources.card2;
            Card3.Image = Properties.Resources.card3;
            DupCard3.Image = Properties.Resources.card3;
            Card4.Image = Properties.Resources.card4;
            DupCard4.Image = Properties.Resources.card4;
            Card5.Image = Properties.Resources.card5;
            DupCard5.Image = Properties.Resources.card5;
            Card6.Image = Properties.Resources.card6;
            DupCard6.Image = Properties.Resources.card6;
            Card7.Image = Properties.Resources.card7;
            DupCard7.Image = Properties.Resources.card7;
            Card8.Image = Properties.Resources.card8;
            DupCard8.Image = Properties.Resources.card8;
            Card9.Image = Properties.Resources.card9;
            DupCard9.Image = Properties.Resources.card9;
            //foreach (PictureBox picture in CardsHolder.Controls)
            //{
            //    picture.Image = Properties.Resources.Снимок1;
            //}

        }
        private void TimerInitialaiser()
        {
            picture.Image = Properties.Resources.Снимок1;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                
            }

        }

        private void ScoreCounter_Click(object sender, EventArgs e)
        {

        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void TimerCounter_Click(object sender, EventArgs e)
        {
            
        }

        private void DupCard3_Click(object sender, EventArgs e)
        {

        }


        private void CardsHolder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(TimerCounter.Text);
            timer = timer-1;
            TimerCounter.Text = Convert.ToString(timer);
            if (timer==0)
            {
                timer2.Stop();
            }
        }
    }
}
