using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form15 : Form
    {
        System.Windows.Forms.Timer tmGame = new System.Windows.Forms.Timer();
        int xBall = 0;
        int yBall = 0;
        int xDelta = 5;
        int yDelta = 5;
        int ballDiameter = 50;

        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            tmGame.Interval = 50;
            tmGame.Tick += tmGame_Tick;
            tmGame.Start();
        }
        private void tmGame_Tick(object sender, EventArgs e)
        {

            xBall += xDelta;
            yBall += yDelta;


            if (xBall + ballDiameter >= this.ClientSize.Width || xBall <= 0)
                xDelta = -xDelta;

            if (yBall + ballDiameter >= this.ClientSize.Height || yBall <= 0)
                yDelta = -yDelta;


            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, xBall, yBall, ballDiameter, ballDiameter);
        }
    }
}
