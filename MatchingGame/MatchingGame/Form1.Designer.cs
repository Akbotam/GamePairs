namespace MatchingGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreCounter = new System.Windows.Forms.Label();
            this.TimerCounter = new System.Windows.Forms.Label();
            this.CardsHolder = new System.Windows.Forms.Panel();
            this.DupCard9 = new System.Windows.Forms.PictureBox();
            this.Card9 = new System.Windows.Forms.PictureBox();
            this.DupCard8 = new System.Windows.Forms.PictureBox();
            this.Card8 = new System.Windows.Forms.PictureBox();
            this.DupCard7 = new System.Windows.Forms.PictureBox();
            this.Card7 = new System.Windows.Forms.PictureBox();
            this.DupCard6 = new System.Windows.Forms.PictureBox();
            this.Card6 = new System.Windows.Forms.PictureBox();
            this.DupCard5 = new System.Windows.Forms.PictureBox();
            this.Card5 = new System.Windows.Forms.PictureBox();
            this.DupCard4 = new System.Windows.Forms.PictureBox();
            this.Card4 = new System.Windows.Forms.PictureBox();
            this.DupCard2 = new System.Windows.Forms.PictureBox();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.DupCard3 = new System.Windows.Forms.PictureBox();
            this.Card3 = new System.Windows.Forms.PictureBox();
            this.DupCard1 = new System.Windows.Forms.PictureBox();
            this.Card1 = new System.Windows.Forms.PictureBox();
            this.CardsHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Font = new System.Drawing.Font("AR CENA", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(1037, 62);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(114, 40);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Score:";
            this.ScoreLabel.Click += new System.EventHandler(this.Score_Click);
            // 
            // ScoreCounter
            // 
            this.ScoreCounter.Font = new System.Drawing.Font("AR CENA", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCounter.Location = new System.Drawing.Point(1157, 62);
            this.ScoreCounter.Name = "ScoreCounter";
            this.ScoreCounter.Size = new System.Drawing.Size(40, 40);
            this.ScoreCounter.TabIndex = 2;
            this.ScoreCounter.Text = "0";
            this.ScoreCounter.Click += new System.EventHandler(this.ScoreCounter_Click);
            // 
            // TimerCounter
            // 
            this.TimerCounter.Font = new System.Drawing.Font("AR CENA", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerCounter.Location = new System.Drawing.Point(1046, 113);
            this.TimerCounter.Name = "TimerCounter";
            this.TimerCounter.Size = new System.Drawing.Size(40, 40);
            this.TimerCounter.TabIndex = 3;
            this.TimerCounter.Text = "5";
            this.TimerCounter.Click += new System.EventHandler(this.TimerCounter_Click);
            // 
            // CardsHolder
            // 
            this.CardsHolder.Controls.Add(this.DupCard9);
            this.CardsHolder.Controls.Add(this.Card9);
            this.CardsHolder.Controls.Add(this.DupCard8);
            this.CardsHolder.Controls.Add(this.Card8);
            this.CardsHolder.Controls.Add(this.DupCard7);
            this.CardsHolder.Controls.Add(this.Card7);
            this.CardsHolder.Controls.Add(this.DupCard6);
            this.CardsHolder.Controls.Add(this.Card6);
            this.CardsHolder.Controls.Add(this.DupCard5);
            this.CardsHolder.Controls.Add(this.Card5);
            this.CardsHolder.Controls.Add(this.DupCard4);
            this.CardsHolder.Controls.Add(this.Card4);
            this.CardsHolder.Controls.Add(this.DupCard2);
            this.CardsHolder.Controls.Add(this.Card2);
            this.CardsHolder.Controls.Add(this.DupCard3);
            this.CardsHolder.Controls.Add(this.Card3);
            this.CardsHolder.Controls.Add(this.DupCard1);
            this.CardsHolder.Controls.Add(this.Card1);
            this.CardsHolder.Location = new System.Drawing.Point(21, 28);
            this.CardsHolder.Name = "CardsHolder";
            this.CardsHolder.Size = new System.Drawing.Size(931, 621);
            this.CardsHolder.TabIndex = 0;
            this.CardsHolder.Paint += new System.Windows.Forms.PaintEventHandler(this.CardsHolder_Paint);
            // 
            // DupCard9
            // 
            this.DupCard9.BackColor = System.Drawing.Color.White;
            this.DupCard9.Location = new System.Drawing.Point(771, 405);
            this.DupCard9.Name = "DupCard9";
            this.DupCard9.Size = new System.Drawing.Size(133, 181);
            this.DupCard9.TabIndex = 35;
            this.DupCard9.TabStop = false;
            this.DupCard9.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Card9
            // 
            this.Card9.BackColor = System.Drawing.Color.White;
            this.Card9.Location = new System.Drawing.Point(616, 405);
            this.Card9.Name = "Card9";
            this.Card9.Size = new System.Drawing.Size(133, 181);
            this.Card9.TabIndex = 34;
            this.Card9.TabStop = false;
            this.Card9.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // DupCard8
            // 
            this.DupCard8.BackColor = System.Drawing.Color.White;
            this.DupCard8.Location = new System.Drawing.Point(462, 405);
            this.DupCard8.Name = "DupCard8";
            this.DupCard8.Size = new System.Drawing.Size(133, 181);
            this.DupCard8.TabIndex = 33;
            this.DupCard8.TabStop = false;
            this.DupCard8.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Card8
            // 
            this.Card8.BackColor = System.Drawing.Color.White;
            this.Card8.Location = new System.Drawing.Point(311, 405);
            this.Card8.Name = "Card8";
            this.Card8.Size = new System.Drawing.Size(133, 181);
            this.Card8.TabIndex = 32;
            this.Card8.TabStop = false;
            this.Card8.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // DupCard7
            // 
            this.DupCard7.BackColor = System.Drawing.Color.White;
            this.DupCard7.Location = new System.Drawing.Point(160, 405);
            this.DupCard7.Name = "DupCard7";
            this.DupCard7.Size = new System.Drawing.Size(133, 181);
            this.DupCard7.TabIndex = 31;
            this.DupCard7.TabStop = false;
            this.DupCard7.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Card7
            // 
            this.Card7.BackColor = System.Drawing.Color.White;
            this.Card7.Location = new System.Drawing.Point(8, 405);
            this.Card7.Name = "Card7";
            this.Card7.Size = new System.Drawing.Size(133, 181);
            this.Card7.TabIndex = 30;
            this.Card7.TabStop = false;
            this.Card7.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // DupCard6
            // 
            this.DupCard6.BackColor = System.Drawing.Color.White;
            this.DupCard6.Location = new System.Drawing.Point(771, 209);
            this.DupCard6.Name = "DupCard6";
            this.DupCard6.Size = new System.Drawing.Size(133, 181);
            this.DupCard6.TabIndex = 29;
            this.DupCard6.TabStop = false;
            this.DupCard6.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Card6
            // 
            this.Card6.BackColor = System.Drawing.Color.White;
            this.Card6.Location = new System.Drawing.Point(616, 209);
            this.Card6.Name = "Card6";
            this.Card6.Size = new System.Drawing.Size(133, 181);
            this.Card6.TabIndex = 28;
            this.Card6.TabStop = false;
            this.Card6.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // DupCard5
            // 
            this.DupCard5.BackColor = System.Drawing.Color.White;
            this.DupCard5.Location = new System.Drawing.Point(462, 209);
            this.DupCard5.Name = "DupCard5";
            this.DupCard5.Size = new System.Drawing.Size(133, 181);
            this.DupCard5.TabIndex = 27;
            this.DupCard5.TabStop = false;
            this.DupCard5.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Card5
            // 
            this.Card5.BackColor = System.Drawing.Color.White;
            this.Card5.Location = new System.Drawing.Point(311, 209);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(133, 181);
            this.Card5.TabIndex = 26;
            this.Card5.TabStop = false;
            this.Card5.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // DupCard4
            // 
            this.DupCard4.BackColor = System.Drawing.Color.White;
            this.DupCard4.Location = new System.Drawing.Point(160, 209);
            this.DupCard4.Name = "DupCard4";
            this.DupCard4.Size = new System.Drawing.Size(133, 181);
            this.DupCard4.TabIndex = 25;
            this.DupCard4.TabStop = false;
            this.DupCard4.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Card4
            // 
            this.Card4.BackColor = System.Drawing.Color.White;
            this.Card4.Location = new System.Drawing.Point(8, 209);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(133, 181);
            this.Card4.TabIndex = 24;
            this.Card4.TabStop = false;
            this.Card4.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // DupCard2
            // 
            this.DupCard2.BackColor = System.Drawing.Color.White;
            this.DupCard2.Location = new System.Drawing.Point(771, 10);
            this.DupCard2.Name = "DupCard2";
            this.DupCard2.Size = new System.Drawing.Size(133, 181);
            this.DupCard2.TabIndex = 23;
            this.DupCard2.TabStop = false;
            this.DupCard2.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Card2
            // 
            this.Card2.BackColor = System.Drawing.Color.White;
            this.Card2.Location = new System.Drawing.Point(616, 10);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(133, 181);
            this.Card2.TabIndex = 22;
            this.Card2.TabStop = false;
            this.Card2.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // DupCard3
            // 
            this.DupCard3.BackColor = System.Drawing.Color.White;
            this.DupCard3.Location = new System.Drawing.Point(462, 10);
            this.DupCard3.Name = "DupCard3";
            this.DupCard3.Size = new System.Drawing.Size(133, 181);
            this.DupCard3.TabIndex = 21;
            this.DupCard3.TabStop = false;
            this.DupCard3.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Card3
            // 
            this.Card3.BackColor = System.Drawing.Color.White;
            this.Card3.Location = new System.Drawing.Point(311, 10);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(133, 181);
            this.Card3.TabIndex = 20;
            this.Card3.TabStop = false;
            this.Card3.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // DupCard1
            // 
            this.DupCard1.BackColor = System.Drawing.Color.White;
            this.DupCard1.Location = new System.Drawing.Point(160, 10);
            this.DupCard1.Name = "DupCard1";
            this.DupCard1.Size = new System.Drawing.Size(133, 181);
            this.DupCard1.TabIndex = 19;
            this.DupCard1.TabStop = false;
            this.DupCard1.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Card1
            // 
            this.Card1.BackColor = System.Drawing.Color.White;
            this.Card1.Location = new System.Drawing.Point(8, 10);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(133, 181);
            this.Card1.TabIndex = 18;
            this.Card1.TabStop = false;
            this.Card1.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 776);
            this.Controls.Add(this.TimerCounter);
            this.Controls.Add(this.ScoreCounter);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.CardsHolder);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Memory Matching Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CardsHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DupCard9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScoreCounter;
        private System.Windows.Forms.Label TimerCounter;
        private System.Windows.Forms.PictureBox Card1;
        private System.Windows.Forms.PictureBox DupCard1;
        private System.Windows.Forms.PictureBox Card3;
        private System.Windows.Forms.PictureBox DupCard3;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.PictureBox DupCard2;
        private System.Windows.Forms.PictureBox Card4;
        private System.Windows.Forms.PictureBox DupCard4;
        private System.Windows.Forms.PictureBox Card5;
        private System.Windows.Forms.PictureBox DupCard5;
        private System.Windows.Forms.PictureBox Card6;
        private System.Windows.Forms.PictureBox DupCard6;
        private System.Windows.Forms.PictureBox Card7;
        private System.Windows.Forms.PictureBox DupCard7;
        private System.Windows.Forms.PictureBox Card8;
        private System.Windows.Forms.Panel CardsHolder;
        private System.Windows.Forms.PictureBox DupCard9;
        private System.Windows.Forms.PictureBox Card9;
        private System.Windows.Forms.PictureBox DupCard8;
    }
}

