using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PaperTracker
{
    public partial class BaseForm : Form
    {
        public delegate void saveCallbackType();
        private saveCallbackType saveCallback;
        private object elementsList;
        private string formType; // either default or todo
        private List<int> selectedItemsIndices;
        private bool onSelectMode = false;

        public BaseForm(object frmElementList, saveCallbackType frmSaveCallback)
        {
            if (frmElementList is Dictionary<string, bool>)
            {
                formType = "todo";
            }
            else if (frmElementList is List<Subject> || frmElementList is List<Topic>)
            {
                formType = "default";
            }
            else
            {
                throw new Exception("Form elements must be one of these types: Dictionary<string, bool>, List<Subject>, List<Topic>!");
            }

            // storing the constructor parameters as attributes
            elementsList = frmElementList;
            saveCallback = frmSaveCallback;

            InitializeComponent();
            RenderElements();
        }

        private void RenderElements()
        {
            flowItemsLayoutPanel.Controls.Clear();

            if (formType == "todo")
            {
                foreach (var element in (Dictionary<string, bool>)elementsList)
                {
                    void onClickHandler(object sender, EventArgs e)
                    {
                        TodoChangeHandler(element.Key, !element.Value);
                    }
                    checkableBtnItem checkBtn;

                    if (element.Value)
                    {
                        checkBtn = new checkableBtnItem(element.Key, onSelectMode, "todo", "done");
                    }
                    else
                    {
                        checkBtn = new checkableBtnItem(element.Key, onSelectMode, "todo");
                    }

                    checkBtn.OnBtnClick += onClickHandler;

                    flowItemsLayoutPanel.Controls.Add(checkBtn);
                }
            }
            else
            {
                if (elementsList is List<Subject>)
                {
                    foreach (var subject in (List<Subject>)elementsList)
                    {
                        checkableBtnItem checkBtn = new checkableBtnItem(subject.name, onSelectMode);

                        void onClickHandler(object sender, EventArgs e)
                        {
                            OpenNewForm(subject);
                        }
                        checkBtn.OnBtnClick += onClickHandler;

                        flowItemsLayoutPanel.Controls.Add(checkBtn);
                    }
                }
                else
                {
                    foreach (var topic in (List<Topic>)elementsList)
                    {
                        checkableBtnItem checkBtn = new checkableBtnItem(topic.name, onSelectMode);

                        void onClickHandler(object sender, EventArgs e)
                        {
                            OpenNewForm(topic);
                        }
                        checkBtn.OnBtnClick += onClickHandler;

                        flowItemsLayoutPanel.Controls.Add(checkBtn);
                    }
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

        private void TodoChangeHandler(string todoElementName, bool wasTodo)
        {
            var elementsDict = (Dictionary<string, bool>)elementsList;
            if (wasTodo)
            {
                elementsDict[todoElementName] = true;
            }
            else
            {
                elementsDict[todoElementName] = false;
            }

            saveCallback();
            RenderElements();
        }

        private void OpenNewForm(Topic topicElement)
        {
            BaseForm subForm = new BaseForm(topicElement.topicPapers, saveCallback);
            subForm.Show();
        }

        private void OpenNewForm(Subject subjectElement)
        {
            BaseForm subform = new BaseForm(subjectElement.topics, saveCallback);
            subform.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NameEntryForm enterNameForm = new NameEntryForm();
            enterNameForm.ShowDialog();
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
