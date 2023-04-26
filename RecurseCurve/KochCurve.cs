
namespace RecurseCurve
{
    public partial class KochCurve : Form
    {
        public KochCurve()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(this.OnPaint);
            this.DoubleBuffered = true;
        }


        //initialize start data
        private int depth = 0; // глибина рекурсії
        private int length = 300; // довжина відрізка
        private int startX = 10, startY = 150; // початкові координати



        protected void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawKochCurve(g, depth, startX, startY, length, 0);
        }



        private void DrawKochCurve(Graphics g, int depth, int x, int y, int len, float angle)
        {
            if (depth == 0)
            { // базовий випадок

                float radians = (float)(Math.PI / 180.0 * angle);
                int x2 = x + (int)(Math.Cos(radians) * len);
                int y2 = y + (int)(Math.Sin(radians) * len);
                g.DrawLine(Pens.Black, x, y, x2, y2);
            }
            else
            { // рекурсивний випадок
                len /= 3;
                DrawKochCurve(g, depth - 1, x, y, len, angle);
                x += (int)(Math.Cos(Math.PI / 180.0 * angle) * len);
                y += (int)(Math.Sin(Math.PI / 180.0 * angle) * len);
                DrawKochCurve(g, depth - 1, x, y, len, angle - 60);
                x += (int)(Math.Cos(Math.PI / 180.0 * (angle - 60)) * len);
                y += (int)(Math.Sin(Math.PI / 180.0 * (angle - 60)) * len);
                DrawKochCurve(g, depth - 1, x, y, len, angle + 60);
                x += (int)(Math.Cos(Math.PI / 180.0 * (angle + 60)) * len);
                y += (int)(Math.Sin(Math.PI / 180.0 * (angle + 60)) * len);
                DrawKochCurve(g, depth - 1, x, y, len, angle);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            depth = int.Parse(tbDeth.Text);
            length = int.Parse(tbLength.Text);
        }
    }
}