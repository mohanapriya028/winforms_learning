namespace Student_Management_System
{
    partial class frmMainForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            topmenu = new MenuStrip();
            mASTERToolStripMenuItem = new ToolStripMenuItem();
            studentform = new ToolStripMenuItem();
            dashboard = new ToolStripMenuItem();
            aCCDASHToolStripMenuItem = new ToolStripMenuItem();
            wINDOWSToolStripMenuItem = new ToolStripMenuItem();
            Changepass = new ToolStripMenuItem();
            exit = new ToolStripMenuItem();
            Mainpanel = new Guna.UI2.WinForms.Guna2Panel();
            topmenu.SuspendLayout();
            SuspendLayout();
            // 
            // topmenu
            // 
            topmenu.BackColor = Color.SteelBlue;
            topmenu.ImageScalingSize = new Size(20, 20);
            topmenu.Items.AddRange(new ToolStripItem[] { mASTERToolStripMenuItem, wINDOWSToolStripMenuItem });
            topmenu.Location = new Point(0, 0);
            topmenu.Name = "topmenu";
            topmenu.Padding = new Padding(6, 2, 0, 8);
            topmenu.Size = new Size(1098, 40);
            topmenu.TabIndex = 1;
            topmenu.Text = "menuStrip1";
            // 
            // mASTERToolStripMenuItem
            // 
            mASTERToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentform, dashboard, aCCDASHToolStripMenuItem });
            mASTERToolStripMenuItem.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mASTERToolStripMenuItem.Name = "mASTERToolStripMenuItem";
            mASTERToolStripMenuItem.Size = new Size(93, 30);
            mASTERToolStripMenuItem.Text = "MASTER";
            // 
            // studentform
            // 
            studentform.BackColor = Color.SteelBlue;
            studentform.Name = "studentform";
            studentform.Size = new Size(284, 30);
            studentform.Text = "STUDENT FORM";
            studentform.Click += studentform_Click;
            // 
            // dashboard
            // 
            dashboard.BackColor = Color.SteelBlue;
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(284, 30);
            dashboard.Text = "STUDENT DASHBOARD";
            dashboard.Click += dashboard_Click;
            // 
            // aCCDASHToolStripMenuItem
            // 
            aCCDASHToolStripMenuItem.Name = "aCCDASHToolStripMenuItem";
            aCCDASHToolStripMenuItem.Size = new Size(284, 30);
            aCCDASHToolStripMenuItem.Text = "ACC DASH";
            aCCDASHToolStripMenuItem.Click += aCCDASHToolStripMenuItem_Click;
            // 
            // wINDOWSToolStripMenuItem
            // 
            wINDOWSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Changepass, exit });
            wINDOWSToolStripMenuItem.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wINDOWSToolStripMenuItem.Name = "wINDOWSToolStripMenuItem";
            wINDOWSToolStripMenuItem.Size = new Size(107, 30);
            wINDOWSToolStripMenuItem.Text = "WINDOWS";
            // 
            // Changepass
            // 
            Changepass.BackColor = Color.SteelBlue;
            Changepass.Name = "Changepass";
            Changepass.Size = new Size(265, 30);
            Changepass.Text = "CHANGE PASSWORD";
            // 
            // exit
            // 
            exit.BackColor = Color.SteelBlue;
            exit.Name = "exit";
            exit.Size = new Size(265, 30);
            exit.Text = "EXIT";
            exit.Click += exit_Click;
            // 
            // Mainpanel
            // 
            Mainpanel.CustomizableEdges = customizableEdges1;
            Mainpanel.Dock = DockStyle.Fill;
            Mainpanel.Location = new Point(0, 40);
            Mainpanel.Name = "Mainpanel";
            Mainpanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Mainpanel.Size = new Size(1098, 573);
            Mainpanel.TabIndex = 2;
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 613);
            Controls.Add(Mainpanel);
            Controls.Add(topmenu);
            MainMenuStrip = topmenu;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "frmMainForm";
            ShowIcon = false;
            WindowState = FormWindowState.Maximized;
            topmenu.ResumeLayout(false);
            topmenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip topmenu;
        private ToolStripMenuItem mASTERToolStripMenuItem;
        private ToolStripMenuItem studentform;
        private ToolStripMenuItem dashboard;
        private ToolStripMenuItem wINDOWSToolStripMenuItem;
        private ToolStripMenuItem Changepass;
        private ToolStripMenuItem exit;
        private Guna.UI2.WinForms.Guna2Panel Mainpanel;
        private ToolStripMenuItem aCCDASHToolStripMenuItem;
    }
}