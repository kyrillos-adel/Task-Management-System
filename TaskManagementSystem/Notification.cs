using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagementSystem
{
    public partial class Notification : UserControl
    {
        public Notification(string title)
        {
            InitializeComponent();
            Fill(title);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            this.Parent?.Controls.Remove(this);
        }

        private void Fill(string title)
        {
            this.txtTitle.Text = title;
        }
    }
}
