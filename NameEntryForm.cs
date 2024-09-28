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
    public partial class NameEntryForm : Form
    {
        public string enteredName { get; private set; }

        public NameEntryForm()
        {
            InitializeComponent();
        }

        private void getEnteredName()
        {
            enteredName = txtNameInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            getEnteredName();
        }

        private void txtNameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getEnteredName();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
