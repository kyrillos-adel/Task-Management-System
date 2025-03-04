namespace TaskManagementSystem
{
    partial class Notification
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
            txtTaskTitle = new Label();
            txtTitle = new Label();
            Remove = new Button();
            SuspendLayout();
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.AutoSize = true;
            txtTaskTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaskTitle.ForeColor = SystemColors.ButtonHighlight;
            txtTaskTitle.Location = new Point(3, 0);
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.Size = new Size(109, 31);
            txtTaskTitle.TabIndex = 0;
            txtTaskTitle.Text = "Over Due";
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.ForeColor = SystemColors.ButtonHighlight;
            txtTitle.Location = new Point(3, 31);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(13, 20);
            txtTitle.TabIndex = 1;
            txtTitle.Text = " ";
            // 
            // Remove
            // 
            Remove.BackColor = Color.DimGray;
            Remove.FlatStyle = FlatStyle.Flat;
            Remove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Remove.ForeColor = SystemColors.ButtonHighlight;
            Remove.Location = new Point(3, 56);
            Remove.Name = "Remove";
            Remove.Size = new Size(143, 29);
            Remove.TabIndex = 2;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += Remove_Click;
            // 
            // Notification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(Remove);
            Controls.Add(txtTitle);
            Controls.Add(txtTaskTitle);
            Name = "Notification";
            Size = new Size(149, 89);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtTaskTitle;
        private Label txtTitle;
        private Button Remove;
    }
}
