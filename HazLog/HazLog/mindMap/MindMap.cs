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
            childHazard("A", 20, 1);
            childHazard("B", 80, 2);
            childHazard("C", 140, 3);
            childHazard("D", 200, 4);
        }

        public void CoreHazard(String name)
        {
            int xpos = this.Size.Width;
            Font font1 = new System.Drawing.Font(this.Font, FontStyle.Bold);
            SolidBrush sb = new SolidBrush(Color.Pink);
            Graphics g = panel1.CreateGraphics();
            RectangleF rectF1 = new RectangleF(40, 40, 40, 40);
            g.FillEllipse(sb, xpos / 2, 20, 50, 50);
            g.DrawString(name, font1, Brushes.Blue, rectF1);
        }

        public void childHazard(String name, int pos, int classification)
        {
            Font font1 = new System.Drawing.Font(this.Font, FontStyle.Bold);
            
            //Graphics g = panel1.CreateGraphics();
            Graphics g = createShape(classification, pos);
            RectangleF rectF1 = new RectangleF(40, 40, 40, 40);
           // g.FillRectangle(sb, pos, 100, 50, 50);
            g.DrawString(name, font1, Brushes.Blue, rectF1);
           
         
        }

        private Graphics createShape(int classification, int pos)
        {

            Graphics g =  panel1.CreateGraphics();
            SolidBrush sb ;
            switch (classification)
            {
                case 1:
                   sb = new SolidBrush(Color.Red);
                    g.FillRectangle(sb, pos, 100, 50, 50);
                    break;

                case 2:
                    sb = new SolidBrush(Color.Yellow);
                    g = panel1.CreateGraphics();
                    g.FillEllipse(sb, pos, 100, 50, 50);
                    break;

                case 3:
                    sb = new SolidBrush(Color.Blue);
                    g = panel1.CreateGraphics();
                    g.FillRectangle(sb, pos, 100, 50, 50);
                    break;

                case 4:
                    sb = new SolidBrush(Color.Green);
                    g = panel1.CreateGraphics();
                    g.FillEllipse(sb, pos, 100, 50, 50);
                  
                    break;

                  
            }
            return g;
        }
    }
}