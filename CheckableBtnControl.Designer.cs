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
            flowLayoutPanel.Size = new Size(152, 36);
            flowLayoutPanel.TabIndex = 0;
            // 
            // checkBox
            // 
            checkBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            checkBox.AutoSize = true;
            checkBox.Location = new Point(3, 3);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(18, 30);
            checkBox.TabIndex = 0;
            checkBox.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            button.AutoSize = true;
            button.Location = new Point(27, 3);
            button.Name = "button";
            button.Size = new Size(122, 30);
            button.TabIndex = 1;
            button.Text = "Sample Subject";
            button.UseVisualStyleBackColor = true;
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
            Size = new Size(155, 39);
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
