using System;
using MemoryGame.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        private bool _allowClick = true;
        private PictureBox _firstGuess;
        private readonly Random _random = new Random();
        private readonly Timer _clickTimer = new Timer();
        int ticks = 30;
        readonly Timer timer = new Timer { Interval = 1000 };
        public Form1()
        {
            InitializeComponent();
            SetRandomImages();
            HideImages();
            StartGameTimer();
            _clickTimer.Interval = 1000;
            _clickTimer.Tick += _clickTimer_Tick;

        }
        private PictureBox[] PictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private static IEnumerable<Image> Images
        {
            get
            {
                return new Image[]
                {
                    Resources.img1,
                    Resources.img2,
                    Resources.img3,
                    Resources.img4,
                    Resources.img5,
                    Resources.img6,
                    Resources.img7,
                    Resources.img8
                };
            }
        }
        private void StartGameTimer()
        {
            timer.Start();
            timer.Tick += delegate
             {
                 ticks--;
                 if (ticks == 1)
                 {
                     timer.Stop();
                     MessageBox.Show("Times Up.", "Memory Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     ResetImages();
                 }
                 var time = TimeSpan.FromSeconds(ticks);
                 lblTIme.Text = "00:" + time.ToString("ss");
             };
        }
        private void ResetImages()
        {
            foreach (var pic in PictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            HideImages();
            SetRandomImages();
            ticks = 30;
            timer.Start();
        }
        private void HideImages()
        {
            foreach (var pic in PictureBoxes)
            {
                pic.Image = Resources.img0;
                //pic.Image = (Image)pic.Tag;
            }
        }
        private PictureBox GetFreeSlot()
        {
            int num;
            do
            {
                num = _random.Next(0, PictureBoxes.Count());
            }
            while (PictureBoxes[num].Tag != null);
            return PictureBoxes[num];

        }

        private void SetRandomImages()
        {
            foreach (var image in Images)
            {
                GetFreeSlot().Tag = image;
                GetFreeSlot().Tag = image;
            }
        }

        private void ClickImag(object sender, EventArgs e)
        {
            if (!_allowClick) return;
            var pic = (PictureBox)sender;
            if (_firstGuess == null)
            {
                _firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;

            }
            pic.Image = (Image)pic.Tag;
            if (pic.Image == _firstGuess.Image && pic != _firstGuess)
            {
                pic.Visible = _firstGuess.Visible = false;
                {
                    _firstGuess = pic;
                }
                HideImages();
            }
            else
            {
                _allowClick = false;
                _clickTimer.Start();
            }
            _firstGuess = null;
            if (PictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("You won.", "Memory Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetImages();
        }
        private void _clickTimer_Tick(object sender, EventArgs e)
        {
            HideImages();
            _allowClick = true;
            _clickTimer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTIme_Click(object sender, EventArgs e)
        {

        }
    }
}
