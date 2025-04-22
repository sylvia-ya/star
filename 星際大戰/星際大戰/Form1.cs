using System.Windows.Forms;

namespace 星際大戰
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int fire = 0;
       List<PictureBox> zdlist = new List<PictureBox>();


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    pictureBox1.Image = Image.FromFile("tank1.gif");
                    pictureBox1.Top = pictureBox1.Top - 5;
                    pictureBox2.Top = pictureBox1.Top - 65;
                    pictureBox2.Left = pictureBox1.Left + 30;
                    fire = 1;
                    break;
                case Keys.Down:
                    pictureBox1.Image = Image.FromFile("tank3.gif");
                    pictureBox1.Top = pictureBox1.Top + 5;
                    pictureBox2.Top = pictureBox1.Top + 130;
                    pictureBox2.Left = pictureBox1.Left + 30;
                    fire = 2;
                    break;
                case Keys.Left:
                    pictureBox1.Image = Image.FromFile("tank4.gif");
                    pictureBox1.Left = pictureBox1.Left - 5;
                    pictureBox2.Top = pictureBox1.Top + 10;
                    pictureBox2.Left = pictureBox1.Left - 70;
                    fire = 3;
                    break;
                case Keys.Right:
                    pictureBox1.Image = Image.FromFile("tank2.gif");
                    pictureBox1.Left = pictureBox1.Left + 5;
                    pictureBox2.Top = pictureBox1.Top + 50;
                    pictureBox2.Left = pictureBox1.Left + 150;
                    fire = 4;
                    break;
                case Keys.Space:

                    pictureBox2.Visible = true;
                    timer1.Enabled = true;
                    break;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            timer1.Interval = 200;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            for (int i = 0; i < 15; i++)
            {
                if (fire == 1)
                {
                    pictureBox2.Top -= 5;
                }
                else if (fire == 2)
                {
                    pictureBox2.Top += 5;
                }
                else if (fire == 3)
                {
                    pictureBox2.Left -= 5;
                }
                else if (fire == 4)
                {
                    pictureBox2.Left += 5;
                }
            }
        }
    }
}