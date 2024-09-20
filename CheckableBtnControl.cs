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
    public partial class checkableBtnItem : UserControl
    {
        public event EventHandler? OnBtnClick;

        public checkableBtnItem(string label, bool visibleCheckmark = false, string btnType = "default", string? toDoBtnState = null)
        {
            InitializeComponent();
            button.Text = label;
            checkBox.Visible = visibleCheckmark;

            if (btnType == "todo")
            {
                if (toDoBtnState == "done")
                {
                    button.Image = Properties.Resources.Done;
                }
                else
                {
                    button.Image = Properties.Resources.ToDo;
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            OnBtnClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
