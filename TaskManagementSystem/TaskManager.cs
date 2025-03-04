using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Model;
using TaskStatus = TaskManagementSystem.Model.TaskStatus;

namespace TaskManagementSystem
{

    public partial class TaskManager : Form
    {

        /// <summary>
        /// SortBy:
        ///         0: Sort by Due Date
        ///         1: Sort by Priority
        ///         2: Sort by Category
        /// </summary>
        private int sortBy = 0;

        private string searchText;

        public Button btnAddNew;

        public static int UserId;

        public static TaskManager tm;
        static int taskCount = 0;

        private string userName;

        // Pagination variables for each panel
        private int pendingPage = 1;
        private int inProgressPage = 1;
        private int completedPage = 1;
        private int tasksPerPage = 2; // Number of tasks to display per page

        public TaskManager()
        {
            InitializeComponent();

            PendingTasks.AllowDrop = true;
            InProgressTasks.AllowDrop = true;
            CompletedTasks.AllowDrop = true;

            using (TaskManagementDB db = new TaskManagementDB())
            {
                userName = db.User
                    .Where(u => u.Id == UserId)
                    .Select(u => u.Name)
                    .First();
            }
            
            txtWelcomeMessage.Text = $@"Welcome {userName.ToUpper()} to your intuitive Task Manager";

            LoadPendingTasks();
            LoadInProgressTasks();
            LoadCompletedTasks();

            tm = this;

            btnAddNew = AddNewTaskBtn;

            TasksCheckTimer.Start();

            CalcAvgCompletionTime();


        }

        public void AddNewTaskBtn_Click(object sender, EventArgs e)
        {
            TaskCard newTask = new TaskCard();

            newTask.Name = $"Task{taskCount++}";

            newTask.Size = new System.Drawing.Size(239, 178);

            PendingTasks.Controls.Add(newTask);

            int addNewTaskBtnIndex = PendingTasks.Controls.IndexOf(AddNewTaskBtn);

            PendingTasks.Controls.SetChildIndex(newTask, addNewTaskBtnIndex);

            AddNewTaskBtn.Visible = false;
        }

        public void LoadPendingTasks()
        {
            PendingTasks.Controls.Clear();
            PendingTasks.Controls.Add(AddNewTaskBtn);

            using (var db = new TaskManagementDB())
            {
                var t = db.TaskItem
                    .Where(t => t.UserId == UserId && t.Status == TaskStatus.Pending);

                if (!string.IsNullOrEmpty(searchText))
                {
                    t = t.Where(t => t.Title.Contains(searchText) || t.Description.Contains(searchText));
                }

                switch (sortBy)
                {
                    case 1:
                        t = t.OrderBy(t => t.Priority);
                        break;

                    case 2:
                        t = t.OrderBy(t => t.CategoryId);
                        break;

                    default:
                        t = t.OrderBy(t => t.DueDate);
                        break;
                }

                var tasks = t.ToList().Skip((pendingPage - 1) * tasksPerPage)
                    .Take(tasksPerPage)
                    .ToList();

                foreach (var task in tasks)
                {
                    PendingTasks.Controls.Add(FillCreatedTaskCard(task, db));
                }

                // Update pagination buttons and label
                PendingPreviousButton.Enabled = pendingPage > 1;
                PendingNextButton.Enabled = tasks.Count == tasksPerPage;
                PendingPageLabel.Text = $"Page {pendingPage}";
            }
        }

        public void LoadInProgressTasks()
        {
            InProgressTasks.Controls.Clear();

            using (var db = new TaskManagementDB())
            {
                var t = db.TaskItem
                    .Where(t => t.UserId == UserId && t.Status == TaskStatus.InProgress);

                if (!string.IsNullOrEmpty(searchText))
                {
                    t = t.Where(t => t.Title.Contains(searchText) || t.Description.Contains(searchText));
                }

                switch (sortBy)
                {
                    case 1:
                        t = t.OrderBy(t => t.Priority);
                        break;

                    case 2:
                        t = t.OrderBy(t => t.CategoryId);
                        break;

                    default:
                        t = t.OrderBy(t => t.DueDate);
                        break;
                }

                var tasks = t.ToList().Skip((inProgressPage - 1) * tasksPerPage)
                    .Take(tasksPerPage)
                    .ToList();

                foreach (var task in tasks)
                {
                    InProgressTasks.Controls.Add(FillCreatedTaskCard(task, db));
                }

                // Update pagination buttons and label
                InProgressPreviousButton.Enabled = inProgressPage > 1;
                InProgressNextButton.Enabled = tasks.Count == tasksPerPage;
                InProgressPageLabel.Text = $"Page {inProgressPage}";
            }
        }

        public void LoadCompletedTasks()
        {
            CompletedTasks.Controls.Clear();

            using (var db = new TaskManagementDB())
            {

                var t = db.TaskItem
                    .Where(t => t.UserId == UserId && t.Status == TaskStatus.Completed);

                if (!string.IsNullOrEmpty(searchText))
                {
                    t = t.Where(t => t.Title.Contains(searchText) || t.Description.Contains(searchText));
                }

                switch (sortBy)
                {
                    case 1:
                        t = t.OrderBy(t => t.Priority);
                        break;

                    case 2:
                        t = t.OrderBy(t => t.CategoryId);
                        break;

                    default:
                        t = t.OrderBy(t => t.DueDate);
                        break;
                }

                var tasks = t.ToList().Skip((completedPage - 1) * tasksPerPage)
                    .Take(tasksPerPage)
                    .ToList();

                foreach (var task in tasks)
                {
                    CompletedTasks.Controls.Add(FillCreatedTaskCard(task, db));
                }

                // Update pagination buttons and label
                CompletedPreviousButton.Enabled = completedPage > 1;
                CompletedNextButton.Enabled = tasks.Count == tasksPerPage;
                CompletedPageLabel.Text = $"Page {completedPage}";
            }
        }

        public CreatedTaskCard FillCreatedTaskCard(TaskItem task, TaskManagementDB db)
        {
            CreatedTaskCard tc = new CreatedTaskCard(task.Id);
            tc.TaskTitleLbl.Text = task.Title;
            tc.TaskDescLbl.Text = task.Description;
            tc.DueTime.Text = task.DueDate.ToString();
            tc.Priority.Text = task.Priority.ToString();
            tc.Category.Text = db.Category
                .Where(c => c.Id == task.CategoryId)
                .Select(c => c.Name)
                .First();
            tc.Name = $"Task{taskCount++}";
            tc.Size = new System.Drawing.Size(239, 180);

            if (task.Status == TaskStatus.Pending)
                tc.BackColor = Color.Bisque;
            else if (task.Status == TaskStatus.InProgress)
                tc.BackColor = Color.Yellow;
            else
                tc.BackColor = Color.LightGreen;

            return (tc);
        }

        private void PendingPreviousButton_Click(object sender, EventArgs e)
        {
            if (pendingPage > 1)
            {
                pendingPage--;
                LoadPendingTasks();
            }
        }

        private void PendingNextButton_Click(object sender, EventArgs e)
        {
            pendingPage++;
            LoadPendingTasks();
        }

        private void InProgressPreviousButton_Click(object sender, EventArgs e)
        {
            if (inProgressPage > 1)
            {
                inProgressPage--;
                LoadInProgressTasks();
            }
        }

        private void InProgressNextButton_Click(object sender, EventArgs e)
        {
            inProgressPage++;
            LoadInProgressTasks();
        }

        private void CompletedPreviousButton_Click(object sender, EventArgs e)
        {
            if (completedPage > 1)
            {
                completedPage--;
                LoadCompletedTasks();
            }
        }

        private void CompletedNextButton_Click(object sender, EventArgs e)
        {
            completedPage++;
            LoadCompletedTasks();
        }

        private void TasksPanels_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(CreatedTaskCard)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void InProgressTasks_DragDrop(object sender, DragEventArgs e)
        {
            CreatedTaskCard task = (CreatedTaskCard)e.Data.GetData(typeof(CreatedTaskCard));

            using (var db = new TaskManagementDB())
            {
                var taskItem = db.TaskItem
                    .First(t => t.Id == task.TaskId);

                if (taskItem.Status == TaskStatus.Completed || taskItem.Status == TaskStatus.InProgress)
                {
                    e.Effect = DragDropEffects.None;
                    return;
                }

                taskItem.Status = TaskStatus.InProgress;
                db.Entry(taskItem).State = EntityState.Modified;
                db.SaveChanges();
            }

            task.BackColor = Color.Yellow;

            LoadCompletedTasks();
            LoadInProgressTasks();
            LoadPendingTasks();

            TasksCheckTimer_Tick(new object(), new EventArgs());
        }

        private void CompletedTasks_DragDrop(object sender, DragEventArgs e)
        {
            CreatedTaskCard task = (CreatedTaskCard)e.Data.GetData(typeof(CreatedTaskCard));

            using (var db = new TaskManagementDB())
            {
                var taskItem = db.TaskItem
                    .First(t => t.Id == task.TaskId);

                taskItem.Status = TaskStatus.Completed;
                taskItem.CompleteTime = DateTime.Now;

                db.Entry(taskItem).State = EntityState.Modified;
                db.SaveChanges();
            }

            task.BackColor = Color.LightGreen;

            LoadCompletedTasks();
            LoadInProgressTasks();
            LoadPendingTasks();

            CalcAvgCompletionTime();
        }

        private void PendingTasks_DragDrop(object sender, DragEventArgs e)
        {
            CreatedTaskCard task = (CreatedTaskCard)e.Data.GetData(typeof(CreatedTaskCard));

            using (var db = new TaskManagementDB())
            {
                var taskItem = db.TaskItem
                    .First(t => t.Id == task.TaskId);

                if (taskItem.Status == TaskStatus.Completed || taskItem.Status == TaskStatus.Pending)
                {
                    e.Effect = DragDropEffects.None;
                    return;
                }

                taskItem.Status = TaskStatus.Pending;
                db.Entry(taskItem).State = EntityState.Modified;
                db.SaveChanges();
            }

            task.BackColor = Color.Bisque;

            LoadCompletedTasks();
            LoadInProgressTasks();
            LoadPendingTasks();
        }

        private void SortTasksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortByString = SortTasksComboBox.SelectedItem.ToString();
            switch (sortByString)
            {
                case "Sort by Due Date":
                    sortBy = 0;
                    break;
                case "Sort by Priority":
                    sortBy = 1;
                    break;
                case "Sort by Category":
                    sortBy = 2;
                    break;
            }

            LoadPendingTasks();
            LoadInProgressTasks();
            LoadCompletedTasks();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            searchText = txtBoxSearch.Text;
            LoadPendingTasks();
            LoadInProgressTasks();
            LoadCompletedTasks();
        }

        private void TaskOverDueNotification_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void TasksCheckTimer_Tick(object sender, EventArgs e)
        {
            using var db = new TaskManagementDB();

            var overdueTasks = db.TaskItem
                .Where(t => t.DueDate < DateTime.Now
                        && t.UserId == UserId
                        && (t.Status != TaskStatus.Completed))
                .ToList();

            foreach (var task in overdueTasks)
            {
                Notification n = new Notification(task.Title);
                n.Height = 95;
                n.Width = 175;
                NotificationPanel.Controls.Add(n);
            }
        }

        private void SidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CalcAvgCompletionTime()
        {
            using var db = new TaskManagementDB();



            var completedTasks = db.TaskItem
                .Where(t => t.UserId == UserId && t.CompleteTime.HasValue)
                .Select(t => t.CompleteTime - t.CreatedAt).ToList();


            if (completedTasks.Count() != 0)
            {
                TimeSpan totalTime = completedTasks.Aggregate(TimeSpan.Zero, (sum, ts) => (TimeSpan)(sum + ts));

                var avgTime = (double)(totalTime.TotalHours) / completedTasks.Count();

                lblAvg.Text = $"{avgTime.ToString("0.00")} Hrs";
            }
        }

        private void CompletedTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnShowReports_Click(object sender, EventArgs e)
        {
            TaskReports tr = new TaskReports();
            tr.Show();
        }

        
    }
}