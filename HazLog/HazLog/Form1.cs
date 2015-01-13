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
namespace HazLog
{
    public partial class Form1 : Form
    {
        private BluePrint _bluePrint;

      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnblue_Click(object sender, EventArgs e)
        {
            _bluePrint = new BluePrint();
            _bluePrint.Show();
        }
    }
}
