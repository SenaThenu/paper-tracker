namespace PaperTracker
{
    partial class NameEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameEntryForm));
            flowLayoutPanel = new FlowLayoutPanel();
            label = new Label();
            txtNameInput = new TextBox();
            btnSubmit = new Button();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.Controls.Add(label);
            flowLayoutPanel.Controls.Add(txtNameInput);
            flowLayoutPanel.Controls.Add(btnSubmit);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(10);
            flowLayoutPanel.Size = new Size(341, 115);
            flowLayoutPanel.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label.ForeColor = SystemColors.ButtonHighlight;
            label.Location = new Point(13, 10);
            label.Name = "label";
            label.Size = new Size(92, 20);
            label.TabIndex = 2;
            label.Text = "Enter Name";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNameInput
            // 
            txtNameInput.Location = new Point(13, 33);
            txtNameInput.Name = "txtNameInput";
            txtNameInput.Size = new Size(316, 27);
            txtNameInput.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSubmit.Location = new Point(13, 66);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(316, 29);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // NameEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(341, 115);
            Controls.Add(flowLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "NameEntryForm";
            Text = "Enter Name";
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Label label;
        private TextBox txtNameInput;
        private Button btnSubmit;
    }
}