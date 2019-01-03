using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Feature2 : Form
    {
        public Feature2()
        {
            addme();
            InitializeComponent();
        }

        private void Feature2_Load(object sender, EventArgs e)
        {

        }
        public int addme()
        {
            int x1 = 1;
            int x2 = 2;
            int sum = x1 + x2;
            return sum;
        }

    }

}
