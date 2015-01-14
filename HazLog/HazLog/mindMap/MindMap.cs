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
            CoreHazard("Loss of deceleration capability");
            childHazard("A", 20, 1);
            childHazard("B", 80, 2);
            childHazard("C", 140, 3);
            childHazard("D", 200, 4);
        }
      
       

        

        public void CoreHazard(String name)
        {
           

            Controls.Add( createBtn( name,20,  20));
        }

        private Button createBtn(String name,int x, int y)
        {
            Button btn = new Button();
            btn.Name = name;
            btn.Text = name;
            //btn.Width = 20;
            //btn.Height = 20;
            btn.Location = new Point(x, y);
            return btn;
        }
        public void childHazard(String name, int pos, int classification)
        {
            
           
         
        }

     
}
    }