namespace PaperTracker
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            toolStrip = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnSelect = new ToolStripButton();
            btnDelete = new ToolStripButton();
            flowItemsLayoutPanel = new FlowLayoutPanel();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip
            // 
            toolStrip.BackColor = Color.Transparent;
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new Size(30, 30);
            toolStrip.Items.AddRange(new ToolStripItem[] { btnAdd, btnSelect, btnDelete });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(800, 37);
            toolStrip.TabIndex = 0;
            toolStrip.Text = "toolStrip";
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Image = Properties.Resources.Plus_Fill;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(34, 34);
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.Transparent;
            btnSelect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSelect.Image = Properties.Resources.Multiselect_Fill;
            btnSelect.ImageTransparentColor = Color.Magenta;
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(34, 34);
            btnSelect.Text = "Select";
            btnSelect.Click += btnSelect_Click;
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDelete.Image = Properties.Resources.Delete_Fill;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(34, 34);
            btnDelete.Text = "Delete";
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // flowItemsLayoutPanel
            // 
            flowItemsLayoutPanel.AutoScroll = true;
            flowItemsLayoutPanel.AutoSize = true;
            flowItemsLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowItemsLayoutPanel.BackColor = Color.Transparent;
            flowItemsLayoutPanel.Dock = DockStyle.Fill;
            flowItemsLayoutPanel.Location = new Point(0, 37);
            flowItemsLayoutPanel.Name = "flowItemsLayoutPanel";
            flowItemsLayoutPanel.Size = new Size(800, 413);
            flowItemsLayoutPanel.TabIndex = 1;
            flowItemsLayoutPanel.TabStop = true;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(flowItemsLayoutPanel);
            Controls.Add(toolStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(400, 250);
            Name = "BaseForm";
            Text = "Paper Tracker";
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip;
        private ToolStripButton btnAdd;
        private ToolStripButton btnSelect;
        private ToolStripButton btnDelete;
        private FlowLayoutPanel flowItemsLayoutPanel;
        private checkableBtnItem checkableBtnItem12;
    }
}