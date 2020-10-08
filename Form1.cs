using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmail_Desktop_Concept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!compose1.Visible) guna2Transition1.ShowSync(compose1);
            else guna2Transition1.HideSync(compose1);
        }
    }
}
