using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TaskManagementSystem.Model;

namespace TaskManagementSystem
{
    public partial class TaskReports: Form
    {
        TaskManagementDB db = new ();

        public TaskReports()
        {
            InitializeComponent();
            LoadChart();
        }

        private void LoadChart()
        {
            var taskStatusCounts = db.TaskItem
                .Where(t => t.UserId == TaskManager.UserId)
                .GroupBy(t => t.Status)
                .Select(g => new { Status = g.Key, Count = g.Count() });


            Series series1 = new Series("Task status")
            {
                ChartType = SeriesChartType.Pie,
                BorderWidth = 1,
                BorderColor = Color.Transparent,
            };
            int totalCount = taskStatusCounts.Sum(t => t.Count);


            foreach (var statusCount in taskStatusCounts)
            {
                double percentage = ((double)statusCount.Count / totalCount) * 100;

                // Add each status and its corresponding count as a data point
                int pointIndex = series1.Points.AddXY(statusCount.Status.ToString(), statusCount.Count);
                series1.Points[pointIndex].Label = $"{percentage:0.##}%";

                series1.Points[pointIndex].LegendText = $"{statusCount.Status.ToString()}";

            }

            chart1.Series.Clear();
            chart1.Series.Add(series1);

            chart1.Titles.Clear();
            chart1.Titles.Add("Task Status Distribution");

            // Refresh the chart
            chart1.Invalidate();
        }
    }
}
