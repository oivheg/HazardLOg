using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HazLog.blueprint
{
    public partial class BluePrint : Form
    {

        PictureBox print1;
        public BluePrint()
        {
            InitializeComponent();
            print1 = new PictureBox();
          print1.Image =  Image.FromFile(@"C:\Users\Øivind\Documents\GitHub\HazardLOg\HazLog\HazLog\blueprint\boeing.png");
          print1.Show();
          print1.SizeMode = PictureBoxSizeMode.StretchImage;
          print1.BackColor = Color.Red;
          //print1.Location = new Point(20, 100); //20 from left and 100 from top
         // print1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
          print1.Dock = DockStyle.Fill;
          this.Controls.Add(print1);
        }



        
    }
}
