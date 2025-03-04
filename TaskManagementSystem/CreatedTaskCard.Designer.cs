namespace TaskManagementSystem
{
    partial class CreatedTaskCard
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
            TaskTitleLbl = new Label();
            TaskDescLbl = new Label();
            DeleteTaskBtn = new Button();
            EditTaskBtn = new Button();
            DueTime = new Label();
            Priority = new Label();
            Category = new Label();
            SuspendLayout();
            // 
            // TaskTitleLbl
            // 
            TaskTitleLbl.AutoSize = true;
            TaskTitleLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaskTitleLbl.ForeColor = Color.FromArgb(64, 64, 64);
            TaskTitleLbl.Location = new Point(12, 12);
            TaskTitleLbl.Name = "TaskTitleLbl";
            TaskTitleLbl.Size = new Size(96, 28);
            TaskTitleLbl.TabIndex = 0;
            TaskTitleLbl.Text = "Task Title";
            // 
            // TaskDescLbl
            // 
            TaskDescLbl.AutoSize = true;
            TaskDescLbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TaskDescLbl.ForeColor = Color.FromArgb(64, 64, 64);
            TaskDescLbl.Location = new Point(12, 50);
            TaskDescLbl.Name = "TaskDescLbl";
            TaskDescLbl.Size = new Size(96, 23);
            TaskDescLbl.TabIndex = 1;
            TaskDescLbl.Text = "Description";
            // 
            // DeleteTaskBtn
            // 
            DeleteTaskBtn.BackColor = Color.Transparent;
            DeleteTaskBtn.BackgroundImage = Properties.Resources.delete;
            DeleteTaskBtn.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteTaskBtn.Cursor = Cursors.Hand;
            DeleteTaskBtn.FlatAppearance.BorderSize = 0;
            DeleteTaskBtn.FlatStyle = FlatStyle.Flat;
            DeleteTaskBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteTaskBtn.ForeColor = Color.White;
            DeleteTaskBtn.Location = new Point(202, 136);
            DeleteTaskBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteTaskBtn.Name = "DeleteTaskBtn";
            DeleteTaskBtn.Size = new Size(28, 30);
            DeleteTaskBtn.TabIndex = 5;
            DeleteTaskBtn.UseVisualStyleBackColor = false;
            DeleteTaskBtn.Click += DeleteTaskBtn_Click;
            // 
            // EditTaskBtn
            // 
            EditTaskBtn.BackColor = Color.Transparent;
            EditTaskBtn.BackgroundImage = Properties.Resources.edit;
            EditTaskBtn.BackgroundImageLayout = ImageLayout.Stretch;
            EditTaskBtn.Cursor = Cursors.Hand;
            EditTaskBtn.FlatAppearance.BorderSize = 0;
            EditTaskBtn.FlatStyle = FlatStyle.Flat;
            EditTaskBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditTaskBtn.ForeColor = Color.White;
            EditTaskBtn.Location = new Point(200, 98);
            EditTaskBtn.Margin = new Padding(3, 4, 3, 4);
            EditTaskBtn.Name = "EditTaskBtn";
            EditTaskBtn.Size = new Size(30, 30);
            EditTaskBtn.TabIndex = 6;
            EditTaskBtn.UseVisualStyleBackColor = false;
            EditTaskBtn.Click += EditTaskBtn_Click;
            // 
            // DueTime
            // 
            DueTime.AutoSize = true;
            DueTime.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DueTime.ForeColor = Color.FromArgb(64, 64, 64);
            DueTime.Location = new Point(12, 110);
            DueTime.Name = "DueTime";
            DueTime.Size = new Size(73, 20);
            DueTime.TabIndex = 7;
            DueTime.Text = "Due Time";
            // 
            // Priority
            // 
            Priority.AutoSize = true;
            Priority.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Priority.ForeColor = Color.FromArgb(64, 64, 64);
            Priority.Location = new Point(12, 145);
            Priority.Name = "Priority";
            Priority.Size = new Size(56, 20);
            Priority.TabIndex = 8;
            Priority.Text = "Priority";
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Category.ForeColor = Color.FromArgb(64, 64, 64);
            Category.Location = new Point(81, 145);
            Category.Name = "Category";
            Category.Size = new Size(69, 20);
            Category.TabIndex = 9;
            Category.Text = "Category";
            // 
            // CreatedTaskCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(Category);
            Controls.Add(Priority);
            Controls.Add(DueTime);
            Controls.Add(EditTaskBtn);
            Controls.Add(DeleteTaskBtn);
            Controls.Add(TaskDescLbl);
            Controls.Add(TaskTitleLbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreatedTaskCard";
            Size = new Size(239, 182);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Label TaskTitleLbl;
        public System.Windows.Forms.Label TaskDescLbl;
        public System.Windows.Forms.Button DeleteTaskBtn;
        public System.Windows.Forms.Button EditTaskBtn;
        public Label DueTime;
        public Label Priority;
        public Label Category;
    }
}
