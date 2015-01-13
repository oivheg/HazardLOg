using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HazLog.blueprint;
using HazLog.treeView;
using HazLog.mindMap;
namespace HazLog
{
    public partial class Form1 : Form
    {
        private BluePrint _bluePrint;
        private TreeViewMain _treeView;
        private MindMap _mindMap;
      
        public Form1()
        {
            InitializeComponent();
            _mindMap = new MindMap();
            _mindMap.Show();
         
        }

     

        private void btnblue_Click(object sender, EventArgs e)
        {
            _bluePrint = new BluePrint();
            _bluePrint.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hazardLogDataSet.HazardLog' table. You can move, or remove it, as needed.
            this.hazardLogTableAdapter.Fill(this.hazardLogDataSet.HazardLog);
           
        }

        private void btntree_Click(object sender, EventArgs e)
        {
            _treeView = new TreeViewMain();
            _treeView.Show();

        }
    }
}
