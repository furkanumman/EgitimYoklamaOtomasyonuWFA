namespace UI
{
    partial class CoordinatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoordinatorForm));
            toolStrip1 = new ToolStrip();
            toolStripSplitButton2 = new ToolStripSplitButton();
            ekleToolStripMenuItem = new ToolStripMenuItem();
            güncelleSilToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSplitButton1 = new ToolStripSplitButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSplitButton3 = new ToolStripSplitButton();
            branchReportToolStripMenuItem = new ToolStripMenuItem();
            classroomReportToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton2, toolStripSeparator1, toolStripSplitButton1, toolStripSeparator2, toolStripSplitButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(884, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton2
            // 
            toolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton2.DropDownItems.AddRange(new ToolStripItem[] { ekleToolStripMenuItem, güncelleSilToolStripMenuItem });
            toolStripSplitButton2.Image = (Image)resources.GetObject("toolStripSplitButton2.Image");
            toolStripSplitButton2.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton2.Name = "toolStripSplitButton2";
            toolStripSplitButton2.Size = new Size(114, 22);
            toolStripSplitButton2.Text = "Eğitmen İşlemleri";
            toolStripSplitButton2.ButtonClick += toolStripSplitButton2_ButtonClick;
            // 
            // ekleToolStripMenuItem
            // 
            ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            ekleToolStripMenuItem.Size = new Size(137, 22);
            ekleToolStripMenuItem.Text = "Ekle";
            ekleToolStripMenuItem.Click += ekleToolStripMenuItem_Click;
            // 
            // güncelleSilToolStripMenuItem
            // 
            güncelleSilToolStripMenuItem.Name = "güncelleSilToolStripMenuItem";
            güncelleSilToolStripMenuItem.Size = new Size(137, 22);
            güncelleSilToolStripMenuItem.Text = "Güncelle/Sil";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(93, 22);
            toolStripSplitButton1.Text = "Sınıf İşlemleri";
            toolStripSplitButton1.ButtonClick += toolStripSplitButton1_ButtonClick;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripSplitButton3
            // 
            toolStripSplitButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton3.DropDownItems.AddRange(new ToolStripItem[] { branchReportToolStripMenuItem, classroomReportToolStripMenuItem });
            toolStripSplitButton3.Image = (Image)resources.GetObject("toolStripSplitButton3.Image");
            toolStripSplitButton3.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton3.Name = "toolStripSplitButton3";
            toolStripSplitButton3.Size = new Size(101, 22);
            toolStripSplitButton3.Text = "Rapor İşlemleri";
            // 
            // branchReportToolStripMenuItem
            // 
            branchReportToolStripMenuItem.Name = "branchReportToolStripMenuItem";
            branchReportToolStripMenuItem.Size = new Size(168, 22);
            branchReportToolStripMenuItem.Text = "Branch Report";
            branchReportToolStripMenuItem.Click += branchReportToolStripMenuItem_Click;
            // 
            // classroomReportToolStripMenuItem
            // 
            classroomReportToolStripMenuItem.Name = "classroomReportToolStripMenuItem";
            classroomReportToolStripMenuItem.Size = new Size(168, 22);
            classroomReportToolStripMenuItem.Text = "Classroom Report";
            classroomReportToolStripMenuItem.Click += classroomReportToolStripMenuItem_Click;
            // 
            // CoordinatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(884, 761);
            Controls.Add(toolStrip1);
            IsMdiContainer = true;
            Name = "CoordinatorForm";
            Text = "CoordinatorForm";
            Load += CoordinatorForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolStripSplitButton2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSplitButton toolStripSplitButton3;
        private ToolStripMenuItem branchReportToolStripMenuItem;
        private ToolStripMenuItem classroomReportToolStripMenuItem;
        private ToolStripMenuItem ekleToolStripMenuItem;
        private ToolStripMenuItem güncelleSilToolStripMenuItem;
    }
}