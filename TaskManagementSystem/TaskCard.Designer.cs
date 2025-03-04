namespace TaskManagementSystem
{
    partial class TaskCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DueTimePicker = new DateTimePicker();
            PriorityCBx = new ComboBox();
            CategoryCBx = new ComboBox();
            ConfirmTaskBtn = new Button();
            TitleTxt = new TextBox();
            DescriptionTxt = new RichTextBox();
            SuspendLayout();
            // 
            // DueTimePicker
            // 
            DueTimePicker.Location = new Point(12, 106);
            DueTimePicker.Margin = new Padding(3, 4, 3, 4);
            DueTimePicker.MaxDate = new DateTime(2027, 12, 31, 0, 0, 0, 0);
            DueTimePicker.MinDate = new DateTime(2025, 2, 4, 0, 0, 0, 0);
            DueTimePicker.Name = "DueTimePicker";
            DueTimePicker.Size = new Size(218, 27);
            DueTimePicker.TabIndex = 2;
            DueTimePicker.Value = new DateTime(2025, 2, 28, 5, 59, 45, 626);
            // 
            // PriorityCBx
            // 
            PriorityCBx.FormattingEnabled = true;
            PriorityCBx.Location = new Point(12, 141);
            PriorityCBx.Margin = new Padding(3, 4, 3, 4);
            PriorityCBx.Name = "PriorityCBx";
            PriorityCBx.Size = new Size(64, 28);
            PriorityCBx.TabIndex = 3;
            PriorityCBx.Text = "Priority";
            // 
            // CategoryCBx
            // 
            CategoryCBx.FormattingEnabled = true;
            CategoryCBx.Location = new Point(82, 141);
            CategoryCBx.Margin = new Padding(3, 4, 3, 4);
            CategoryCBx.Name = "CategoryCBx";
            CategoryCBx.Size = new Size(64, 28);
            CategoryCBx.TabIndex = 4;
            CategoryCBx.Text = "Category";
            // 
            // ConfirmTaskBtn
            // 
            ConfirmTaskBtn.BackColor = Color.FromArgb(0, 120, 215);
            ConfirmTaskBtn.Cursor = Cursors.Hand;
            ConfirmTaskBtn.FlatAppearance.BorderSize = 0;
            ConfirmTaskBtn.FlatStyle = FlatStyle.Flat;
            ConfirmTaskBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmTaskBtn.ForeColor = Color.White;
            ConfirmTaskBtn.Location = new Point(152, 139);
            ConfirmTaskBtn.Margin = new Padding(3, 4, 3, 4);
            ConfirmTaskBtn.Name = "ConfirmTaskBtn";
            ConfirmTaskBtn.Size = new Size(78, 30);
            ConfirmTaskBtn.TabIndex = 6;
            ConfirmTaskBtn.Text = "Confirm";
            ConfirmTaskBtn.UseVisualStyleBackColor = false;
            ConfirmTaskBtn.Click += ConfirmTaskBtn_Click;
            // 
            // TitleTxt
            // 
            TitleTxt.BackColor = Color.White;
            TitleTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleTxt.ForeColor = Color.FromArgb(64, 64, 64);
            TitleTxt.Location = new Point(12, 12);
            TitleTxt.Name = "TitleTxt";
            TitleTxt.PlaceholderText = "Enter task title";
            TitleTxt.Size = new Size(218, 34);
            TitleTxt.TabIndex = 7;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.BackColor = Color.White;
            DescriptionTxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionTxt.ForeColor = Color.FromArgb(64, 64, 64);
            DescriptionTxt.Location = new Point(12, 49);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(218, 50);
            DescriptionTxt.TabIndex = 8;
            DescriptionTxt.Text = "";
            // 
            // TaskCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(DescriptionTxt);
            Controls.Add(TitleTxt);
            Controls.Add(ConfirmTaskBtn);
            Controls.Add(CategoryCBx);
            Controls.Add(PriorityCBx);
            Controls.Add(DueTimePicker);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaskCard";
            Size = new Size(239, 175);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DateTimePicker DueTimePicker;
        private System.Windows.Forms.ComboBox PriorityCBx;
        private System.Windows.Forms.ComboBox CategoryCBx;
        private System.Windows.Forms.Button ConfirmTaskBtn;
        private TextBox TitleTxt;
        private RichTextBox DescriptionTxt;
    }
}