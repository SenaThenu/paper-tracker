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
        private List<string> elementNamesList;
        private List<bool>? todoStates; // used for todo buttons (true -> todo, false -> done) [used when frmType is "todo"]
        private string formType;
        private bool onSelectMode = false;

        public BaseForm(List<string> elementNames, string frmType = "default", List<bool>? elementTodoStates = null)
        {
            elementNamesList = elementNames;
            todoStates = elementTodoStates;
            formType = frmType;

            InitializeComponent();
            RenderElements();
        }

        private void RenderElements()
        {
            flowItemsLayoutPanel.Controls.Clear();
            for (int i = 0; i < elementNamesList.Count; i++)
            {
                string name = elementNamesList[i];

                if (formType == "todo")
                {
                    if (todoStates != null)
                    {
                        checkableBtnItem checkBtn;
                        if (todoStates[i])
                        {
                            checkBtn = new checkableBtnItem(name, onSelectMode, "todo");
                        }
                        else
                        {
                            checkBtn = new checkableBtnItem(name, onSelectMode, "todo", "done");
                        }
                        flowItemsLayoutPanel.Controls.Add(checkBtn);
                    }
                }
                else
                {
                    checkableBtnItem checkBtn = new checkableBtnItem(name, onSelectMode);
                    flowItemsLayoutPanel.Controls.Add(checkBtn);
                }
            }
        }

        private void SetSelectMode()
        {
            if (onSelectMode)
            {
                btnSelect.BackColor = Color.MidnightBlue;
                btnDelete.Visible = true;
            }
            else
            {
                btnSelect.BackColor = Color.Transparent;
                btnDelete.Visible = false;
            }

            RenderElements();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hey you clicked me!");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (onSelectMode)
            {
                onSelectMode = false;
            }
            else
            {
                onSelectMode = true;
            }

            SetSelectMode();
        }
    }
}
