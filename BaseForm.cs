using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperTracker
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hey you clicked me!");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
        }
    }
}
