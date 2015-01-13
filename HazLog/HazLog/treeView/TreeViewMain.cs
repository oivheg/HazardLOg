using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HazLog.treeView
{
    public partial class TreeViewMain : Form
    {
        public TreeViewMain()
        {
            InitializeComponent();
        }

        private void TreeView_Load(object sender, EventArgs e)
        {
            //
            // This is the first node in the view.
            //
            TreeNode treeNode = new TreeNode("Windows");
            treeView1.Nodes.Add(treeNode);
            //
            // Another node following the first node.
            //
            treeNode = new TreeNode("Linux");
            treeView1.Nodes.Add(treeNode);
            //
            // Create two child nodes and put them in an array.
            // ... Add the third node, and specify these as its children.
            //
            TreeNode node2 = new TreeNode("C#");
            TreeNode node3 = new TreeNode("VB.NET");
            TreeNode[] array = new TreeNode[] { node2, node3 };
            //
            // Final node.
            //
            treeNode = new TreeNode("Dot Net Perls", array);
            treeView1.Nodes.Add(treeNode);
        }

      
    }
}
