using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemMatchGame
{
    public partial class GameWindow : Form
    {
        int score = 0;
        Random location = new Random();
        List<Point> points = new List<Point>();
        bool again = false;
        PictureBox PendingImages1;
        PictureBox PendingImages2;
        public GameWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "5";
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in CardsHolder.Controls)
            {         
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }

            timer1.Start();
            timer2.Start();
            Card1.Image = Properties.Resources.img1;
            DupCard1.Image = Properties.Resources.img1;
            Card2.Image = Properties.Resources.img2;
            DupCard2.Image = Properties.Resources.img2;
            Card3.Image = Properties.Resources.img3;
            DupCard3.Image = Properties.Resources.img3;
            Card4.Image = Properties.Resources.img4;
            DupCard4.Image = Properties.Resources.img4;
            Card5.Image = Properties.Resources.img5;
            DupCard5.Image = Properties.Resources.img5;
            Card6.Image = Properties.Resources.img6;
            DupCard6.Image = Properties.Resources.img6;
            Card7.Image = Properties.Resources.img7;
            DupCard7.Image = Properties.Resources.img7;
            Card8.Image = Properties.Resources.img8;
            DupCard8.Image = Properties.Resources.img8;
            Card9.Image = Properties.Resources.Card9;
            DupCard9.Image = Properties.Resources.Card9;

            //foreach (PictureBox picture in CardsHolder.Controls)
            //{
            //    picture.Image = Properties.Resources.img0;
            //}
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            //foreach (PictureBox picture in CardsHolder.Controls)
            //{
            //    picture.Image = Properties.Resources.img0;
            //}

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in CardsHolder.Controls)
            {   
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.img0;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text);
            timer = timer - 1;
            label1.Text = Convert.ToString(timer);
            if (timer ==0)
            {
                timer2.Stop();
            }

        }
        #region Cards
        private void Card1_Click(object sender, EventArgs e)
        {
            Card1.Image = Properties.Resources.img1;
            if (PendingImages1 == null)
            {
                PendingImages1 = Card1;
            }
            else if (PendingImages1!=null && PendingImages2==null)
            {
                PendingImages2 = Card1;
            }
            if (PendingImages1!=null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card1.Enabled = false;
                    DupCard1.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DupCard1_Click(object sender, EventArgs e)
        {
            DupCard1.Image = Properties.Resources.img1;
            if (PendingImages1 == null)
            {
                PendingImages1 = DupCard1;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = DupCard1;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card1.Enabled = false;
                    DupCard1.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            Card2.Image = Properties.Resources.img2;
            if (PendingImages1 == null)
            {
                PendingImages1 = Card2;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = Card2;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card2.Enabled = false;
                    DupCard2.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DupCard2_Click(object sender, EventArgs e)
        {
            DupCard2.Image = Properties.Resources.img2;
            if (PendingImages1 == null)
            {
                PendingImages1 = DupCard2;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = DupCard2;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card2.Enabled = false;
                    DupCard2.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            Card3.Image = Properties.Resources.img3;
            if (PendingImages1 == null)
            {
                PendingImages1 = Card3;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = Card3;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card3.Enabled = false;
                    DupCard3.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DupCard3_Click(object sender, EventArgs e)
        {
            DupCard3.Image = Properties.Resources.img3;
            if (PendingImages1 == null)
            {
                PendingImages1 = DupCard3;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = DupCard3;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card3.Enabled = false;
                    DupCard3.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            Card4.Image = Properties.Resources.img4;
            if (PendingImages1 == null)
            {
                PendingImages1 = Card4;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = Card4;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card4.Enabled = false;
                    DupCard4.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DupCard4_Click(object sender, EventArgs e)
        {
            DupCard4.Image = Properties.Resources.img4;
            if (PendingImages1 == null)
            {
                PendingImages1 = DupCard4;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = DupCard4;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card4.Enabled = false;
                    DupCard4.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            Card5.Image = Properties.Resources.img5;
            if (PendingImages1 == null)
            {
                PendingImages1 = Card5;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = Card5;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card5.Enabled = false;
                    DupCard5.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DupCard5_Click(object sender, EventArgs e)
        {
            DupCard5.Image = Properties.Resources.img5;
            if (PendingImages1 == null)
            {
                PendingImages1 = DupCard5;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = DupCard5;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card5.Enabled = false;
                    DupCard5.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            Card6.Image = Properties.Resources.img6;
            if (PendingImages1 == null)
            {
                PendingImages1 = Card6;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = Card6;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card6.Enabled = false;
                    DupCard6.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DupCard6_Click(object sender, EventArgs e)
        {
            DupCard6.Image = Properties.Resources.img6;
            if (PendingImages1 == null)
            {
                PendingImages1 = DupCard6;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = DupCard6;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card6.Enabled = false;
                    DupCard6.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card7_Click(object sender, EventArgs e)
        {
            Card7.Image = Properties.Resources.img7;
            if (PendingImages1 == null)
            {
                PendingImages1 = Card7;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = Card7;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card7.Enabled = false;
                    DupCard7.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DupCard7_Click(object sender, EventArgs e)
        {
            DupCard7.Image = Properties.Resources.img7;
            if (PendingImages1 == null)
            {
                PendingImages1 = DupCard7;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = DupCard7;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {

                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card7.Enabled = false;
                    DupCard7.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card8_Click(object sender, EventArgs e)
        {
            Card8.Image = Properties.Resources.img8;
            if (PendingImages1 == null)
            {
                PendingImages1 = Card8;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = Card8;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {

                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card8.Enabled = false;
                    DupCard8.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DupCard8_Click(object sender, EventArgs e)
        {
            DupCard8.Image = Properties.Resources.img8;
            if (PendingImages1 == null)
            {
                PendingImages1 = DupCard8;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = DupCard8;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card8.Enabled = false;
                    DupCard8.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card9_Click(object sender, EventArgs e)
        {
            Card9.Image = Properties.Resources.Card9;
            if (PendingImages1 == null)
            {
                PendingImages1 = Card9;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = Card9;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card9.Enabled = false;
                    DupCard9.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DupCard9_Click(object sender, EventArgs e)
        {
            DupCard9.Image = Properties.Resources.Card9;
            if (PendingImages1 == null)
            {
                PendingImages1 = DupCard9;
            }
            else if (PendingImages1 != null && PendingImages2 == null)
            {
                PendingImages2 = DupCard9;
            }
            if (PendingImages1 != null && PendingImages2 != null)
            {
                if (PendingImages1.Tag == PendingImages2.Tag)
                {
                    PendingImages1 = null;
                    PendingImages2 = null;
                    Card9.Enabled = false;
                    DupCard9.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }
        #endregion

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PendingImages1.Image = Properties.Resources.img0;
            PendingImages2.Image = Properties.Resources.img0;
            PendingImages1 = null;
            PendingImages2 = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
