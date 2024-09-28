namespace PaperTracker
{
    partial class checkableBtnItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel = new FlowLayoutPanel();
            checkBox = new CheckBox();
            button = new Button();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel.Controls.Add(checkBox);
            flowLayoutPanel.Controls.Add(button);
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(80, 56);
            flowLayoutPanel.TabIndex = 0;
            // 
            // checkBox
            // 
            checkBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            checkBox.AutoSize = true;
            checkBox.Location = new Point(3, 3);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(18, 50);
            checkBox.TabIndex = 0;
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // button
            // 
            button.AutoSize = true;
            button.BackColor = Color.Black;
            button.Cursor = Cursors.Hand;
            button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button.ForeColor = SystemColors.Control;
            button.Location = new Point(27, 3);
            button.MinimumSize = new Size(50, 50);
            button.Name = "button";
            button.Padding = new Padding(5);
            button.Size = new Size(50, 50);
            button.TabIndex = 1;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // checkableBtnItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Transparent;
            Controls.Add(flowLayoutPanel);
            Name = "checkableBtnItem";
            Size = new Size(83, 59);
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private CheckBox checkBox;
        private Button button;
    }
}
