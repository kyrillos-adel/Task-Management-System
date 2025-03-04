namespace TaskManagementSystem
{
    partial class TaskManager
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PendingTasks = new FlowLayoutPanel();
            AddNewTaskBtn = new Button();
            InProgressTasks = new FlowLayoutPanel();
            CompletedTasks = new FlowLayoutPanel();
            SidebarPanel = new Panel();
            label4 = new Label();
            NotificationPanel = new FlowLayoutPanel();
            btnShowReports = new Button();
            lblAvg = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBoxSearch = new TextBox();
            SortTasksComboBox = new ComboBox();
            LogoutButton = new Button();
            PendingTitleLabel = new Label();
            InProgressTitleLabel = new Label();
            CompletedTitleLabel = new Label();
            PendingPreviousButton = new Button();
            PendingNextButton = new Button();
            PendingPageLabel = new Label();
            InProgressPreviousButton = new Button();
            InProgressNextButton = new Button();
            InProgressPageLabel = new Label();
            CompletedPreviousButton = new Button();
            CompletedNextButton = new Button();
            CompletedPageLabel = new Label();
            TaskOverDueNotification = new NotifyIcon(components);
            TasksCheckTimer = new System.Windows.Forms.Timer(components);
            txtWelcomeMessage = new Label();
            notifyIcon1 = new NotifyIcon(components);
            SidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PendingTasks
            // 
            PendingTasks.AutoScroll = true;
            PendingTasks.BackColor = Color.FromArgb(240, 240, 240);
            PendingTasks.BorderStyle = BorderStyle.FixedSingle;
            PendingTasks.Location = new Point(231, 105);
            PendingTasks.Name = "PendingTasks";
            PendingTasks.Size = new Size(267, 474);
            PendingTasks.TabIndex = 0;
            PendingTasks.DragDrop += PendingTasks_DragDrop;
            PendingTasks.DragEnter += TasksPanels_DragEnter;
            // 
            // AddNewTaskBtn
            // 
            AddNewTaskBtn.BackColor = Color.FromArgb(0, 120, 215);
            AddNewTaskBtn.FlatAppearance.BorderSize = 0;
            AddNewTaskBtn.FlatStyle = FlatStyle.Flat;
            AddNewTaskBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewTaskBtn.ForeColor = Color.White;
            AddNewTaskBtn.Location = new Point(3, 3);
            AddNewTaskBtn.Name = "AddNewTaskBtn";
            AddNewTaskBtn.Size = new Size(238, 42);
            AddNewTaskBtn.TabIndex = 0;
            AddNewTaskBtn.Text = "Add New Task";
            AddNewTaskBtn.UseVisualStyleBackColor = false;
            AddNewTaskBtn.Click += AddNewTaskBtn_Click;
            // 
            // InProgressTasks
            // 
            InProgressTasks.BackColor = Color.FromArgb(240, 240, 240);
            InProgressTasks.BorderStyle = BorderStyle.FixedSingle;
            InProgressTasks.Location = new Point(557, 105);
            InProgressTasks.Name = "InProgressTasks";
            InProgressTasks.Size = new Size(245, 474);
            InProgressTasks.TabIndex = 1;
            InProgressTasks.DragDrop += InProgressTasks_DragDrop;
            InProgressTasks.DragEnter += TasksPanels_DragEnter;
            // 
            // CompletedTasks
            // 
            CompletedTasks.BackColor = Color.FromArgb(240, 240, 240);
            CompletedTasks.BorderStyle = BorderStyle.FixedSingle;
            CompletedTasks.Location = new Point(854, 105);
            CompletedTasks.Name = "CompletedTasks";
            CompletedTasks.Size = new Size(245, 474);
            CompletedTasks.TabIndex = 1;
            CompletedTasks.DragDrop += CompletedTasks_DragDrop;
            CompletedTasks.DragEnter += TasksPanels_DragEnter;
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.FromArgb(50, 50, 50);
            SidebarPanel.Controls.Add(label4);
            SidebarPanel.Controls.Add(NotificationPanel);
            SidebarPanel.Controls.Add(btnShowReports);
            SidebarPanel.Controls.Add(lblAvg);
            SidebarPanel.Controls.Add(label3);
            SidebarPanel.Controls.Add(label2);
            SidebarPanel.Controls.Add(label1);
            SidebarPanel.Controls.Add(txtBoxSearch);
            SidebarPanel.Controls.Add(SortTasksComboBox);
            SidebarPanel.Controls.Add(LogoutButton);
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(0, 0);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(200, 640);
            SidebarPanel.TabIndex = 2;
            SidebarPanel.Paint += SidebarPanel_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 356);
            label4.Name = "label4";
            label4.Size = new Size(163, 31);
            label4.TabIndex = 22;
            label4.Text = "Notifications";
            // 
            // NotificationPanel
            // 
            NotificationPanel.BackColor = Color.Silver;
            NotificationPanel.Location = new Point(12, 390);
            NotificationPanel.Name = "NotificationPanel";
            NotificationPanel.Size = new Size(178, 184);
            NotificationPanel.TabIndex = 21;
            // 
            // btnShowReports
            // 
            btnShowReports.BackColor = Color.Green;
            btnShowReports.FlatAppearance.BorderSize = 0;
            btnShowReports.FlatStyle = FlatStyle.Flat;
            btnShowReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowReports.ForeColor = Color.White;
            btnShowReports.Location = new Point(10, 282);
            btnShowReports.Name = "btnShowReports";
            btnShowReports.Size = new Size(180, 40);
            btnShowReports.TabIndex = 20;
            btnShowReports.Text = "Show Reports";
            btnShowReports.UseVisualStyleBackColor = false;
            btnShowReports.Click += btnShowReports_Click;
            // 
            // lblAvg
            // 
            lblAvg.AutoSize = true;
            lblAvg.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvg.ForeColor = SystemColors.ButtonHighlight;
            lblAvg.Location = new Point(12, 248);
            lblAvg.Name = "lblAvg";
            lblAvg.Size = new Size(83, 31);
            lblAvg.TabIndex = 19;
            lblAvg.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(10, 214);
            label3.Name = "label3";
            label3.Size = new Size(188, 24);
            label3.TabIndex = 18;
            label3.Text = "Completion Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(10, 183);
            label2.Name = "label2";
            label2.Size = new Size(109, 31);
            label2.TabIndex = 17;
            label2.Text = "Average";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(81, 27);
            label1.TabIndex = 16;
            label1.Text = "Search";
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(10, 50);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(180, 27);
            txtBoxSearch.TabIndex = 15;
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
            // 
            // SortTasksComboBox
            // 
            SortTasksComboBox.BackColor = Color.FromArgb(70, 70, 70);
            SortTasksComboBox.FlatStyle = FlatStyle.Flat;
            SortTasksComboBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SortTasksComboBox.ForeColor = Color.White;
            SortTasksComboBox.FormattingEnabled = true;
            SortTasksComboBox.Items.AddRange(new object[] { "Sort by Due Date", "Sort by Priority", "Sort by Category" });
            SortTasksComboBox.Location = new Point(10, 118);
            SortTasksComboBox.Name = "SortTasksComboBox";
            SortTasksComboBox.Size = new Size(180, 31);
            SortTasksComboBox.TabIndex = 0;
            SortTasksComboBox.Text = "Sort Tasks";
            SortTasksComboBox.SelectedIndexChanged += SortTasksComboBox_SelectedIndexChanged;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.FromArgb(255, 80, 80);
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutButton.ForeColor = Color.White;
            LogoutButton.Location = new Point(10, 580);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(180, 40);
            LogoutButton.TabIndex = 1;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // PendingTitleLabel
            // 
            PendingTitleLabel.AutoSize = true;
            PendingTitleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PendingTitleLabel.Location = new Point(231, 70);
            PendingTitleLabel.Name = "PendingTitleLabel";
            PendingTitleLabel.Size = new Size(108, 32);
            PendingTitleLabel.TabIndex = 3;
            PendingTitleLabel.Text = "Pending";
            // 
            // InProgressTitleLabel
            // 
            InProgressTitleLabel.AutoSize = true;
            InProgressTitleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InProgressTitleLabel.Location = new Point(557, 70);
            InProgressTitleLabel.Name = "InProgressTitleLabel";
            InProgressTitleLabel.Size = new Size(144, 32);
            InProgressTitleLabel.TabIndex = 4;
            InProgressTitleLabel.Text = "In Progress";
            // 
            // CompletedTitleLabel
            // 
            CompletedTitleLabel.AutoSize = true;
            CompletedTitleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompletedTitleLabel.Location = new Point(854, 70);
            CompletedTitleLabel.Name = "CompletedTitleLabel";
            CompletedTitleLabel.Size = new Size(138, 32);
            CompletedTitleLabel.TabIndex = 5;
            CompletedTitleLabel.Text = "Completed";
            CompletedTitleLabel.Click += CompletedTitleLabel_Click;
            // 
            // PendingPreviousButton
            // 
            PendingPreviousButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PendingPreviousButton.Location = new Point(231, 589);
            PendingPreviousButton.Name = "PendingPreviousButton";
            PendingPreviousButton.Size = new Size(50, 40);
            PendingPreviousButton.TabIndex = 6;
            PendingPreviousButton.Text = "◄";
            PendingPreviousButton.UseVisualStyleBackColor = true;
            PendingPreviousButton.Click += PendingPreviousButton_Click;
            // 
            // PendingNextButton
            // 
            PendingNextButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PendingNextButton.Location = new Point(448, 589);
            PendingNextButton.Name = "PendingNextButton";
            PendingNextButton.Size = new Size(50, 40);
            PendingNextButton.TabIndex = 7;
            PendingNextButton.Text = "►";
            PendingNextButton.UseVisualStyleBackColor = true;
            PendingNextButton.Click += PendingNextButton_Click;
            // 
            // PendingPageLabel
            // 
            PendingPageLabel.AutoSize = true;
            PendingPageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PendingPageLabel.Location = new Point(331, 599);
            PendingPageLabel.Name = "PendingPageLabel";
            PendingPageLabel.Size = new Size(70, 28);
            PendingPageLabel.TabIndex = 8;
            PendingPageLabel.Text = "Page 1";
            // 
            // InProgressPreviousButton
            // 
            InProgressPreviousButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InProgressPreviousButton.Location = new Point(557, 589);
            InProgressPreviousButton.Name = "InProgressPreviousButton";
            InProgressPreviousButton.Size = new Size(50, 40);
            InProgressPreviousButton.TabIndex = 9;
            InProgressPreviousButton.Text = "◄";
            InProgressPreviousButton.UseVisualStyleBackColor = true;
            InProgressPreviousButton.Click += InProgressPreviousButton_Click;
            // 
            // InProgressNextButton
            // 
            InProgressNextButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InProgressNextButton.Location = new Point(752, 589);
            InProgressNextButton.Name = "InProgressNextButton";
            InProgressNextButton.Size = new Size(50, 40);
            InProgressNextButton.TabIndex = 10;
            InProgressNextButton.Text = "►";
            InProgressNextButton.UseVisualStyleBackColor = true;
            InProgressNextButton.Click += InProgressNextButton_Click;
            // 
            // InProgressPageLabel
            // 
            InProgressPageLabel.AutoSize = true;
            InProgressPageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InProgressPageLabel.Location = new Point(631, 599);
            InProgressPageLabel.Name = "InProgressPageLabel";
            InProgressPageLabel.Size = new Size(70, 28);
            InProgressPageLabel.TabIndex = 11;
            InProgressPageLabel.Text = "Page 1";
            // 
            // CompletedPreviousButton
            // 
            CompletedPreviousButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompletedPreviousButton.Location = new Point(854, 589);
            CompletedPreviousButton.Name = "CompletedPreviousButton";
            CompletedPreviousButton.Size = new Size(50, 40);
            CompletedPreviousButton.TabIndex = 12;
            CompletedPreviousButton.Text = "◄";
            CompletedPreviousButton.UseVisualStyleBackColor = true;
            CompletedPreviousButton.Click += CompletedPreviousButton_Click;
            // 
            // CompletedNextButton
            // 
            CompletedNextButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompletedNextButton.Location = new Point(1049, 589);
            CompletedNextButton.Name = "CompletedNextButton";
            CompletedNextButton.Size = new Size(50, 40);
            CompletedNextButton.TabIndex = 13;
            CompletedNextButton.Text = "►";
            CompletedNextButton.UseVisualStyleBackColor = true;
            CompletedNextButton.Click += CompletedNextButton_Click;
            // 
            // CompletedPageLabel
            // 
            CompletedPageLabel.AutoSize = true;
            CompletedPageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CompletedPageLabel.Location = new Point(931, 599);
            CompletedPageLabel.Name = "CompletedPageLabel";
            CompletedPageLabel.Size = new Size(70, 28);
            CompletedPageLabel.TabIndex = 14;
            CompletedPageLabel.Text = "Page 1";
            // 
            // TaskOverDueNotification
            // 
            TaskOverDueNotification.BalloonTipIcon = ToolTipIcon.Warning;
            TaskOverDueNotification.Text = "notifyIcon1";
            TaskOverDueNotification.Visible = true;
            TaskOverDueNotification.MouseDoubleClick += TaskOverDueNotification_MouseDoubleClick;
            // 
            // TasksCheckTimer
            // 
            TasksCheckTimer.Enabled = true;
            TasksCheckTimer.Interval = 60000;
            TasksCheckTimer.Tick += TasksCheckTimer_Tick;
            // 
            // txtWelcomeMessage
            // 
            txtWelcomeMessage.AutoSize = true;
            txtWelcomeMessage.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWelcomeMessage.ForeColor = SystemColors.ButtonHighlight;
            txtWelcomeMessage.Location = new Point(216, 20);
            txtWelcomeMessage.Name = "txtWelcomeMessage";
            txtWelcomeMessage.Size = new Size(0, 31);
            txtWelcomeMessage.TabIndex = 18;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // TaskManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 640);
            Controls.Add(txtWelcomeMessage);
            Controls.Add(CompletedPageLabel);
            Controls.Add(CompletedNextButton);
            Controls.Add(CompletedPreviousButton);
            Controls.Add(InProgressPageLabel);
            Controls.Add(InProgressNextButton);
            Controls.Add(InProgressPreviousButton);
            Controls.Add(PendingPageLabel);
            Controls.Add(PendingNextButton);
            Controls.Add(PendingPreviousButton);
            Controls.Add(CompletedTitleLabel);
            Controls.Add(InProgressTitleLabel);
            Controls.Add(PendingTitleLabel);
            Controls.Add(SidebarPanel);
            Controls.Add(PendingTasks);
            Controls.Add(InProgressTasks);
            Controls.Add(CompletedTasks);
            Name = "TaskManager";
            Text = "Task Manager";
            SidebarPanel.ResumeLayout(false);
            SidebarPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel PendingTasks;
        private FlowLayoutPanel InProgressTasks;
        private FlowLayoutPanel CompletedTasks;
        private Button AddNewTaskBtn;
        private Panel SidebarPanel;
        private ComboBox SortTasksComboBox;
        private Button LogoutButton;
        private Label PendingTitleLabel;
        private Label InProgressTitleLabel;
        private Label CompletedTitleLabel;
        private Button PendingPreviousButton;
        private Button PendingNextButton;
        private Label PendingPageLabel;
        private Button InProgressPreviousButton;
        private Button InProgressNextButton;
        private Label InProgressPageLabel;
        private Button CompletedPreviousButton;
        private Button CompletedNextButton;
        private Label CompletedPageLabel;
        private Label label1;
        private TextBox txtBoxSearch;
        private NotifyIcon TaskOverDueNotification;
        private System.Windows.Forms.Timer TasksCheckTimer;
        private Label label2;
        private Label label3;
        private Label lblAvg;
        private Button btnShowReports;
        private Label txtWelcomeMessage;
        private Label label4;
        private FlowLayoutPanel NotificationPanel;
        private NotifyIcon notifyIcon1;
        private Notification notification1;
    }
}