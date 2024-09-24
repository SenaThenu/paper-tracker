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

        private string formType; // either subject, topic or todo
        // frmElments are one of the following datatypes:
        List<Subject> subjects;
        List<Topic> topics;
        Dictionary<string, bool> todoDict;

        private List<int> selectedItemsIndices;
        private bool onSelectMode = false;

        public BaseForm(object frmElements, saveCallbackType frmSaveCallback)
        {
            if (frmElements is Dictionary<string, bool>)
            {
                formType = "todo";
                todoDict = (Dictionary<string, bool>)frmElements;
            }
            else if (frmElements is List<Subject>)
            {
                formType = "subject";
                subjects = (List<Subject>)frmElements;
            }
            else if (frmElements is List<Topic>)
            {
                formType = "topic";
                topics = (List<Topic>)frmElements;
            }
            else
            {
                throw new Exception("Form elements must be one of these types: Dictionary<string, bool>, List<Subject>, List<Topic>!");
            }

            saveCallback = frmSaveCallback;

            InitializeComponent();
            RenderElements();
        }

        private void RenderElements()
        {
            flowItemsLayoutPanel.Controls.Clear();

            if (formType == "todo")
            {
                foreach (var element in todoDict)
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
            else if (formType == "subject")
            {
                foreach (var subject in subjects)
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
                foreach (var topic in topics)
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
            if (wasTodo)
            {
                todoDict[todoElementName] = true;
            }
            else
            {
                todoDict[todoElementName] = false;
            }

            saveCallback();
            RenderElements();
        }

        private void OpenNewForm(Topic topicElement)
        {
            BaseForm subForm = new BaseForm(topicElement.topicPapers, saveCallback);
            subForm.Text = $"{topicElement.name} (Topic) - Paper Tracker";
            subForm.Show();
        }

        private void OpenNewForm(Subject subjectElement)
        {
            BaseForm subForm = new BaseForm(subjectElement.topics, saveCallback);
            subForm.Text = $"{subjectElement.name} (Subject) - Paper Tracker";
            subForm.Show();
        }

        private void AddNewElement(string name)
        {
            if (formType == "todo")
            {
                todoDict[name] = false;
            }
            else if (formType == "subject")
            {
                subjects.Add(new Subject(name));
            }
            else
            {
                topics.Add(new Topic(name));
            }
            saveCallback();
            RenderElements();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (NameEntryForm nameForm = new NameEntryForm())
            {
                if (nameForm.ShowDialog() == DialogResult.OK)
                {
                    string enteredName = nameForm.enteredName;
                    AddNewElement(enteredName);
                }
            }
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
