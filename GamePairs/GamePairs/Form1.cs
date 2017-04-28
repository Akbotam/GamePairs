using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePairs
{
    public partial class Form1 : Form

    {   
       public string[] icon=new string[]
        {"I", "I", "W", "W", "M", "M", "A", "A", "T", "T", "P", "P", "O", "O", "E", "E", "K", "K", "L", "L"

         };
        Random random = new Random();
        //icon= icon.OrderBy(X => random.Next()).ToArray();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i=0; i<4; i++)
            {
                for (int j=0; j<5; j++)
                {
                    Button btn = new Button();
                    btn.Text = "?";
                    btn.BackgroundImage = Image.FromFile(@"C:\Users\Андрей\Desktop\Professional English (B2)\bitmapfon.jpg");
                    btn.Location = new Point(j * 150, i * 150);
                    btn.Size = new Size(150, 150);
                    btn.Click += new EventHandler(number_click);
                    Controls.Add(btn);
                }
            }

        }

        private void number_click(object sender, EventArgs e)
        {
            int m = 0;
            Button btn = sender as Button;
            for (int i = 0; i < 20; i++)
            {
                btn.Text = icon[i];
            }
            for (int i = 0; i < 20; i++) {
                if (icon[i] == icon[i + 1])
                {
                    btn.Text = "";
                    m++;
                }
        }  if (m==10)
            {
                Display.Text = "Congratulations!";
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
