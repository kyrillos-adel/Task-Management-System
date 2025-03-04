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

namespace TaskManagementSystem
{

    public partial class CreatedTaskCard : UserControl
    {
        private int taskId;

        public int TaskId
        {
            get => taskId;
        }
        private bool isDragging = false;
        private Point offset;

        public CreatedTaskCard(int taskId)
        {
            this.taskId = taskId;
            InitializeComponent();
            this.MouseDown += CreatedTaskCard_MouseDown;
            //this.MouseMove += CreatedTaskCard_MouseMove;
            this.MouseUp += CreatedTaskCard_MouseUp;
            this.taskId = taskId;
        }

        private void CreatedTaskCard_MouseDown(object? sender, MouseEventArgs e)
        {
            this.DoDragDrop(this, DragDropEffects.Move);

            //if (e.Button == MouseButtons.Left)
            //{
            //    this.isDragging = true;
            //    this.offset = e.Location;
            //}
        }

        //private void CreatedTaskCard_MouseMove(object? sender, MouseEventArgs e)
        //{
        //    if (this.isDragging)
        //    {
        //        Point newLocation = this.PointToScreen(e.Location);
        //        newLocation.Offset(-offset.X, -offset.Y);
        //        this.Location = this.Parent.PointToClient(newLocation);
        //    }
        //}

        private void CreatedTaskCard_MouseUp(object? sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                isDragging = false;

                // Check if the control is over another FlowLayoutPanel
                foreach (Control control in this.Parent.Parent.Controls)
                {
                    if (control is FlowLayoutPanel targetPanel && control != this.Parent)
                    {
                        if (control.Bounds.Contains(this.PointToScreen(Point.Empty)))
                        {
                            // Remove the control from the current panel
                            this.Parent.Controls.Remove(this);

                            // Add the control to the target panel
                            targetPanel.Controls.Add(this);
                            break;
                        }
                    }
                }
            }
        }

        private void DeleteTaskBtn_Click(object sender, EventArgs e)
        {
            using var db = new TaskManagementDB();

            var taskToDelete = db.TaskItem
                .FirstOrDefault(t => t.Id == this.TaskId);

            if (taskToDelete == null) return;

            db.TaskItem.Remove(taskToDelete);
            db.SaveChanges();

            this.Parent?.Controls.Remove(this);
        }

        private void EditTaskBtn_Click(object sender, EventArgs e)
        {
            using var db = new TaskManagementDB();
            
            var task = db.TaskItem
                .FirstOrDefault(t => t.Id == this.TaskId);

            if (task == null) return;

            TaskCard tc = new TaskCard(task);

            int idx = this.Parent.Controls.IndexOf(this);
            
            this.Parent.Controls.Add(tc);
            this.Parent.Controls.SetChildIndex(tc, idx);
            this.Parent.Controls.Remove(this);
        }
    }
}
