namespace Animation___Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            pictureBox1.Location = new Point(x + 5, y);

            if (x > this.Width)
                pictureBox1.Location = new Point(-pictureBox1.Width, y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.pictureBox1.Location = new Point(e.X, e.Y);
        }
    }
}