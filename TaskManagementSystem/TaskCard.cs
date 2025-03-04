using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementSystem.Model;
using TaskStatus = TaskManagementSystem.Model.TaskStatus;

namespace TaskManagementSystem
{
    public partial class TaskCard : UserControl
    {
        private int? taskIdToEdit;

        private TaskManagementDB dbContext = new TaskManagementDB();

        public TaskCard(TaskItem task)
            : this()
        {
            this.taskIdToEdit = task.Id;

            this.TitleTxt.Text = task.Title;
            this.DescriptionTxt.Text = task.Description;
            this.DueTimePicker.Value = task.DueDate;
            this.PriorityCBx.SelectedItem = task.Priority;
            this.CategoryCBx.SelectedItem = dbContext.Category
                .Where(c => c.Id == task.CategoryId)
                .Select(c => c.Name)
                .FirstOrDefault();
        }

        public TaskCard()
        {
            InitializeComponent();

            LoadCategorisComboBox();
            LoadPriorityComboBox();
        }

        public void LoadCategorisComboBox()
        {

            this.CategoryCBx.DataSource = dbContext.Category
                .Distinct()
                .Select(c => c.Name)
                .ToList();
        }

        public void LoadPriorityComboBox()
        {
            this.PriorityCBx.DataSource = new List<TaskPriority>()
            {
                TaskPriority.Low, TaskPriority.Medium, TaskPriority.High
            };
        }

        private void ConfirmTaskBtn_Click(object sender, EventArgs e)
        {
            TaskItem task;

            string title = this.TitleTxt.Text;
            string description = this.DescriptionTxt.Text;
            DateTime dueDate = this.DueTimePicker.Value;
            TaskPriority priority = (TaskPriority)this.PriorityCBx.SelectedItem;
            string categoryName = this.CategoryCBx.SelectedItem.ToString();

            if (taskIdToEdit != null)
            {
                task = dbContext.TaskItem.FirstOrDefault(t => t.Id == taskIdToEdit);
                if (task != null)
                {
                    task.Title = title;
                    task.Description = description;
                    task.DueDate = dueDate;
                    task.Priority = priority;
                    task.CategoryId = dbContext.Category
                        .Where(c => c.Name == categoryName)
                        .Select(c => c.Id)
                        .FirstOrDefault();
                    task.UserId = TaskManager.UserId;

                    dbContext.SaveChanges();
                }
            }
            else
            {
                task = new TaskItem();
                if (title != null && title != ""
                                  && description != null && description != "")
                {
                    task.Title = title;
                    task.Description = description;
                    task.DueDate = dueDate;
                    task.Priority = priority;
                    task.Status = TaskStatus.Pending;
                    task.CategoryId = dbContext.Category
                        .Where(c => c.Name == categoryName)
                        .Select(c => c.Id)
                        .FirstOrDefault();
                    task.UserId = TaskManager.UserId;


                    dbContext.TaskItem.Add(task);
                    dbContext.SaveChanges();
                }
            }

            this.Parent.Controls.Remove(this);
            this.Dispose();
            TaskManager.tm.LoadPendingTasks();
            TaskManager.tm.LoadInProgressTasks();
            TaskManager.tm.LoadCompletedTasks();

            TaskManager.tm.btnAddNew.Visible = true;
        }
    }
}
