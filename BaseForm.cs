using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        private List<int> selectedItemsIndices = [];
        private List<string> selectedTodoNames = [];
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
                    checkableBtnItem checkBtn;

                    if (element.Value)
                    {
                        checkBtn = new checkableBtnItem(element.Key, onSelectMode, "todo", "done");
                    }
                    else
                    {
                        checkBtn = new checkableBtnItem(element.Key, onSelectMode, "todo");
                    }

                    void onClickHandler(object sender, EventArgs e)
                    {
                        TodoChangeHandler(element.Key, !element.Value);
                    }
                    checkBtn.OnBtnClick += onClickHandler;

                    void todoSelectedStateHandler(object sender, EventArgs e)
                    {
                        bool exists = selectedTodoNames.Contains(element.Key);
                        if (exists)
                        {
                            selectedTodoNames.Remove(element.Key);
                        }
                        else
                        {
                            selectedTodoNames.Add(element.Key);
                        }
                    }
                    checkBtn.OnSelectedStateChanged += todoSelectedStateHandler;

                    flowItemsLayoutPanel.Controls.Add(checkBtn);
                }
            }
            else if (formType == "subject")
            {
                for (var i = 0; i < subjects.Count; i++)
                {
                    Subject subject = subjects[i];
                    checkableBtnItem checkBtn = new checkableBtnItem(subject.name, onSelectMode);

                    void onClickHandler(object sender, EventArgs e)
                    {
                        OpenNewForm(subject);
                    }
                    checkBtn.OnBtnClick += onClickHandler;
                    checkBtn.OnSelectedStateChanged += GetNormalSelectedStateHandler(i);

                    flowItemsLayoutPanel.Controls.Add(checkBtn);
                }
            }
            else
            {
                for (var i = 0; i < topics.Count; i++)
                {
                    Topic topic = topics[i];
                    checkableBtnItem checkBtn = new checkableBtnItem(topic.name, onSelectMode);

                    void onClickHandler(object sender, EventArgs e)
                    {
                        OpenNewForm(topic);
                    }
                    checkBtn.OnBtnClick += onClickHandler;
                    checkBtn.OnSelectedStateChanged += GetNormalSelectedStateHandler(i);

                    flowItemsLayoutPanel.Controls.Add(checkBtn);
                }
            }
        }

        private EventHandler GetNormalSelectedStateHandler(int index)
        {
            // this is common for topic and subject forms (handling their selected state changes)
            // for todo forms a different handler is defined in RenderElements()
            void SelectedStateChangeHandler(object sender, EventArgs e)
            {
                bool exists = selectedItemsIndices.Contains(index);
                if (exists)
                {
                    selectedItemsIndices.Remove(index);
                }
                else
                {
                    selectedItemsIndices.Add(index);
                }
            }
            return SelectedStateChangeHandler;
        }

        private void ClearSelected()
        {
            selectedItemsIndices = [];
            selectedTodoNames = [];
        }

        private void SetSelectMode()
        {
            ClearSelected();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (formType == "todo")
            {
                foreach (string todoName in selectedTodoNames)
                {
                    todoDict.Remove(todoName);
                }
            }
            else
            {
                int nDeleted = 0; // used to deviate the value as items are removed
                selectedItemsIndices.Sort();

                foreach (int selectedIndex in selectedItemsIndices)
                {
                    if (formType == "subject")
                    {
                        subjects.RemoveAt(selectedIndex - nDeleted);
                    }
                    else
                    {
                        topics.RemoveAt(selectedIndex - nDeleted);
                    }
                    nDeleted += 1;
                }
            }

            ClearSelected();
            saveCallback();
            RenderElements();
        }
    }
}
