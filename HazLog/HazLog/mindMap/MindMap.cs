using System;
using System.Drawing;
using System.Windows.Forms;

namespace HazLog.mindMap
{
    public partial class MindMap : Form
    {
        

        public MindMap()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

           
            CoreHazard("Loss of deceleration capability");
            childHazard("A", 20);
            childHazard("B", 80);
            childHazard("C", 140);
            childHazard("D", 200);
            


        }



        public void CoreHazard(String name)
        {

            int xpos = this.Size.Width;
            Font font1 = new System.Drawing.Font(this.Font, FontStyle.Bold);
            SolidBrush sb = new SolidBrush(Color.Pink);
            Graphics g = panel1.CreateGraphics();
            RectangleF rectF1 = new RectangleF(40,40,40,40);
            g.FillEllipse(sb, xpos/2, 20, 50, 50);
            g.DrawString(name, font1, Brushes.Blue, rectF1);
        }

        public void childHazard(String name, int pos)
        {
            
            Font font1 = new System.Drawing.Font(this.Font, FontStyle.Bold);
            SolidBrush sb = new SolidBrush(Color.Red);
            Graphics g = panel1.CreateGraphics();
            RectangleF rectF1 = new RectangleF(40, 40, 40, 40);
            g.FillRectangle(sb, pos, 100, 50, 50);
            g.DrawString(name, font1, Brushes.Blue, rectF1);

            pos += 20;
        }


    }
}
