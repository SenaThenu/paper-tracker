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
            checkableBtnItem1 = new checkableBtnItem();
            checkableBtnItem2 = new checkableBtnItem();
            checkableBtnItem3 = new checkableBtnItem();
            checkableBtnItem4 = new checkableBtnItem();
            checkableBtnItem5 = new checkableBtnItem();
            checkableBtnItem6 = new checkableBtnItem();
            checkableBtnItem7 = new checkableBtnItem();
            checkableBtnItem8 = new checkableBtnItem();
            checkableBtnItem9 = new checkableBtnItem();
            checkableBtnItem10 = new checkableBtnItem();
            checkableBtnItem11 = new checkableBtnItem();
            checkableBtnItem12 = new checkableBtnItem();
            toolStrip.SuspendLayout();
            flowItemsLayoutPanel.SuspendLayout();
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
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(34, 34);
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSelect
            // 
            btnSelect.CheckOnClick = true;
            btnSelect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSelect.Image = (Image)resources.GetObject("btnSelect.Image");
            btnSelect.ImageTransparentColor = Color.Magenta;
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(34, 34);
            btnSelect.Text = "Select";
            btnSelect.Click += btnSelect_Click;
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(34, 34);
            btnDelete.Text = "Delete";
            btnDelete.Visible = false;
            // 
            // flowItemsLayoutPanel
            // 
            flowItemsLayoutPanel.AutoScroll = true;
            flowItemsLayoutPanel.AutoSize = true;
            flowItemsLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowItemsLayoutPanel.BackColor = Color.Transparent;
            flowItemsLayoutPanel.Controls.Add(checkableBtnItem1);
            flowItemsLayoutPanel.Controls.Add(checkableBtnItem2);
            flowItemsLayoutPanel.Controls.Add(checkableBtnItem3);
            flowItemsLayoutPanel.Controls.Add(checkableBtnItem4);
            flowItemsLayoutPanel.Controls.Add(checkableBtnItem5);
            flowItemsLayoutPanel.Controls.Add(checkableBtnItem6);
            flowItemsLayoutPanel.Controls.Add(checkableBtnItem7);
            flowItemsLayoutPanel.Controls.Add(checkableBtnItem8);
            flowItemsLayoutPanel.Controls.Add(checkableBtnItem9);
            flowItemsLayoutPanel.Controls.Add(checkableBtnItem10);
            flowItemsLayoutPanel.Controls.Add(checkableBtnItem11);
            flowItemsLayoutPanel.Controls.Add(checkableBtnItem12);
            flowItemsLayoutPanel.Dock = DockStyle.Fill;
            flowItemsLayoutPanel.Location = new Point(0, 37);
            flowItemsLayoutPanel.Name = "flowItemsLayoutPanel";
            flowItemsLayoutPanel.Size = new Size(800, 413);
            flowItemsLayoutPanel.TabIndex = 1;
            flowItemsLayoutPanel.TabStop = true;
            // 
            // checkableBtnItem1
            // 
            checkableBtnItem1.AutoSize = true;
            checkableBtnItem1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            checkableBtnItem1.BackColor = Color.Transparent;
            checkableBtnItem1.Location = new Point(3, 3);
            checkableBtnItem1.Name = "checkableBtnItem1";
            checkableBtnItem1.Size = new Size(155, 39);
            checkableBtnItem1.TabIndex = 0;
            // 
            // checkableBtnItem2
            // 
            checkableBtnItem2.AutoSize = true;
            checkableBtnItem2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            checkableBtnItem2.BackColor = Color.Transparent;
            checkableBtnItem2.Location = new Point(164, 3);
            checkableBtnItem2.Name = "checkableBtnItem2";
            checkableBtnItem2.Size = new Size(155, 39);
            checkableBtnItem2.TabIndex = 1;
            // 
            // checkableBtnItem3
            // 
            checkableBtnItem3.AutoSize = true;
            checkableBtnItem3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            checkableBtnItem3.BackColor = Color.Transparent;
            checkableBtnItem3.Location = new Point(325, 3);
            checkableBtnItem3.Name = "checkableBtnItem3";
            checkableBtnItem3.Size = new Size(155, 39);
            checkableBtnItem3.TabIndex = 2;
            // 
            // checkableBtnItem4
            // 
            checkableBtnItem4.AutoSize = true;
            checkableBtnItem4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            checkableBtnItem4.BackColor = Color.Transparent;
            checkableBtnItem4.Location = new Point(486, 3);
            checkableBtnItem4.Name = "checkableBtnItem4";
            checkableBtnItem4.Size = new Size(155, 39);
            checkableBtnItem4.TabIndex = 3;
            // 
            // checkableBtnItem5
            // 
            checkableBtnItem5.AutoSize = true;
            checkableBtnItem5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            checkableBtnItem5.BackColor = Color.Transparent;
            checkableBtnItem5.Location = new Point(3, 48);
            checkableBtnItem5.Name = "checkableBtnItem5";
            checkableBtnItem5.Size = new Size(155, 39);
            checkableBtnItem5.TabIndex = 4;
            // 
            // checkableBtnItem6
            // 
            checkableBtnItem6.AutoSize = true;
            checkableBtnItem6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            checkableBtnItem6.BackColor = Color.Transparent;
            checkableBtnItem6.Location = new Point(164, 48);
            checkableBtnItem6.Name = "checkableBtnItem6";
            checkableBtnItem6.Size = new Size(155, 39);
            checkableBtnItem6.TabIndex = 5;
            // 
            // checkableBtnItem7
            // 
            checkableBtnItem7.AutoSize = true;
            checkableBtnItem7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            checkableBtnItem7.BackColor = Color.Transparent;
            checkableBtnItem7.Location = new Point(325, 48);
            checkableBtnItem7.Name = "checkableBtnItem7";
            checkableBtnItem7.Size = new Size(155, 39);
            checkableBtnItem7.TabIndex = 6;
            // 
            // checkableBtnItem8
            // 
            checkableBtnItem8.AutoSize = true;
            checkableBtnItem8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            checkableBtnItem8.BackColor = Color.Transparent;
            checkableBtnItem8.Location = new Point(486, 48);
            checkableBtnItem8.Name = "checkableBtnItem8";
            checkableBtnItem8.Size = new Size(155, 39);
            checkableBtnItem8.TabIndex = 7;
            // 
            // checkableBtnItem9
            // 
            checkableBtnItem9.AutoSize = true;
            checkableBtnItem9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            checkableBtnItem9.BackColor = Color.Transparent;
            checkableBtnItem9.Location = new Point(3, 93);
            checkableBtnItem9.Name = "checkableBtnItem9";
            checkableBtnItem9.Size = new Size(155, 39);
            checkableBtnItem9.TabIndex = 8;
            // 
            // checkableBtnItem10
            // 
            checkableBtnItem10.AutoSize = true;
            checkableBtnItem10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            checkableBtnItem10.BackColor = Color.Transparent;
            checkableBtnItem10.Location = new Point(164, 93);
            checkableBtnItem10.Name = "checkableBtnItem10";
            checkableBtnItem10.Size = new Size(155, 39);
            checkableBtnItem10.TabIndex = 9;
            // 
            // checkableBtnItem11
            // 
            checkableBtnItem11.AutoSize = true;
            checkableBtnItem11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            checkableBtnItem11.BackColor = Color.Transparent;
            checkableBtnItem11.Location = new Point(325, 93);
            checkableBtnItem11.Name = "checkableBtnItem11";
            checkableBtnItem11.Size = new Size(155, 39);
            checkableBtnItem11.TabIndex = 10;
            // 
            // checkableBtnItem12
            // 
            checkableBtnItem12.AutoSize = true;
            checkableBtnItem12.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            checkableBtnItem12.BackColor = Color.Transparent;
            checkableBtnItem12.Location = new Point(486, 93);
            checkableBtnItem12.Name = "checkableBtnItem12";
            checkableBtnItem12.Size = new Size(155, 39);
            checkableBtnItem12.TabIndex = 11;
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
            flowItemsLayoutPanel.ResumeLayout(false);
            flowItemsLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip;
        private ToolStripButton btnAdd;
        private ToolStripButton btnSelect;
        private ToolStripButton btnDelete;
        private FlowLayoutPanel flowItemsLayoutPanel;
        private checkableBtnItem checkableBtnItem1;
        private checkableBtnItem checkableBtnItem2;
        private checkableBtnItem checkableBtnItem3;
        private checkableBtnItem checkableBtnItem4;
        private checkableBtnItem checkableBtnItem5;
        private checkableBtnItem checkableBtnItem6;
        private checkableBtnItem checkableBtnItem7;
        private checkableBtnItem checkableBtnItem8;
        private checkableBtnItem checkableBtnItem9;
        private checkableBtnItem checkableBtnItem10;
        private checkableBtnItem checkableBtnItem11;
        private checkableBtnItem checkableBtnItem12;
    }
}