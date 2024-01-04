namespace UI
{
    partial class AdministratorForm
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
            toolStrip1 = new ToolStrip();
            toolStripSplitButtonUser = new ToolStripDropDownButton();
            ToolStripMenuItemAdd = new ToolStripMenuItem();
            ToolStripMenuItemUpdateDelete = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripDropDownBranch = new ToolStripDropDownButton();
            ToolStripMenuItemBranchCrud = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripDropDownButtonClass = new ToolStripDropDownButton();
            ekleGüncelleSilToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripDropDownButtonReport = new ToolStripDropDownButton();
            RaporToolStripMenuItemGeneralReport = new ToolStripMenuItem();
            ToolStripMenuItemBranchReport = new ToolStripMenuItem();
            ToolStripMenuItemClassReport = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripDropDownButtonEducation = new ToolStripDropDownButton();
            ToolStripMenuItemEducationCrud = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButtonUser, toolStripSeparator1, toolStripDropDownBranch, toolStripSeparator2, toolStripDropDownButtonClass, toolStripSeparator4, toolStripDropDownButtonReport, toolStripSeparator3, toolStripDropDownButtonEducation });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(884, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButtonUser
            // 
            toolStripSplitButtonUser.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButtonUser.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemAdd, ToolStripMenuItemUpdateDelete });
            toolStripSplitButtonUser.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripSplitButtonUser.Name = "toolStripSplitButtonUser";
            toolStripSplitButtonUser.Size = new Size(124, 22);
            toolStripSplitButtonUser.Text = "Kullanıcı İşlemleri";
            // 
            // ToolStripMenuItemAdd
            // 
            ToolStripMenuItemAdd.Name = "ToolStripMenuItemAdd";
            ToolStripMenuItemAdd.Size = new Size(145, 22);
            ToolStripMenuItemAdd.Text = "Ekle";
            ToolStripMenuItemAdd.Click += ekleToolStripMenuItem_Click;
            // 
            // ToolStripMenuItemUpdateDelete
            // 
            ToolStripMenuItemUpdateDelete.Name = "ToolStripMenuItemUpdateDelete";
            ToolStripMenuItemUpdateDelete.Size = new Size(145, 22);
            ToolStripMenuItemUpdateDelete.Text = "Güncelle/Sil";
            ToolStripMenuItemUpdateDelete.Click += guncelleSilToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripDropDownBranch
            // 
            toolStripDropDownBranch.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownBranch.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemBranchCrud });
            toolStripDropDownBranch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripDropDownBranch.ImageTransparentColor = Color.White;
            toolStripDropDownBranch.Name = "toolStripDropDownBranch";
            toolStripDropDownBranch.Size = new Size(105, 22);
            toolStripDropDownBranch.Text = "Şube İşlemleri";
            toolStripDropDownBranch.ToolTipText = "Şube İşlemleri";
            // 
            // ToolStripMenuItemBranchCrud
            // 
            ToolStripMenuItemBranchCrud.Name = "ToolStripMenuItemBranchCrud";
            ToolStripMenuItemBranchCrud.Size = new Size(174, 22);
            ToolStripMenuItemBranchCrud.Text = "Ekle/Güncelle/Sil";
            ToolStripMenuItemBranchCrud.Click += ekleGüncelleSilToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripDropDownButtonClass
            // 
            toolStripDropDownButtonClass.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButtonClass.DropDownItems.AddRange(new ToolStripItem[] { ekleGüncelleSilToolStripMenuItem });
            toolStripDropDownButtonClass.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripDropDownButtonClass.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButtonClass.Name = "toolStripDropDownButtonClass";
            toolStripDropDownButtonClass.Size = new Size(100, 22);
            toolStripDropDownButtonClass.Text = "Sınıf İşlemleri";
            // 
            // ekleGüncelleSilToolStripMenuItem
            // 
            ekleGüncelleSilToolStripMenuItem.Name = "ekleGüncelleSilToolStripMenuItem";
            ekleGüncelleSilToolStripMenuItem.Size = new Size(174, 22);
            ekleGüncelleSilToolStripMenuItem.Text = "Ekle/Güncelle/Sil";
            ekleGüncelleSilToolStripMenuItem.Click += ekleGüncelleSilToolStripMenuItem_Click_1;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // toolStripDropDownButtonReport
            // 
            toolStripDropDownButtonReport.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButtonReport.DropDownItems.AddRange(new ToolStripItem[] { RaporToolStripMenuItemGeneralReport, ToolStripMenuItemBranchReport, ToolStripMenuItemClassReport });
            toolStripDropDownButtonReport.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripDropDownButtonReport.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButtonReport.Name = "toolStripDropDownButtonReport";
            toolStripDropDownButtonReport.Size = new Size(111, 22);
            toolStripDropDownButtonReport.Text = "Rapor İşlemleri";
            toolStripDropDownButtonReport.ToolTipText = "Rapor İşlemleri";
            // 
            // RaporToolStripMenuItemGeneralReport
            // 
            RaporToolStripMenuItemGeneralReport.Name = "RaporToolStripMenuItemGeneralReport";
            RaporToolStripMenuItemGeneralReport.Size = new Size(150, 22);
            RaporToolStripMenuItemGeneralReport.Text = "Genel Rapor";
            RaporToolStripMenuItemGeneralReport.Click += genelRaporToolStripMenuItem_Click;
            // 
            // ToolStripMenuItemBranchReport
            // 
            ToolStripMenuItemBranchReport.Name = "ToolStripMenuItemBranchReport";
            ToolStripMenuItemBranchReport.Size = new Size(150, 22);
            ToolStripMenuItemBranchReport.Text = "Şube Rapor";
            ToolStripMenuItemBranchReport.Click += ToolStripMenuItemBranchReport_Click;
            // 
            // ToolStripMenuItemClassReport
            // 
            ToolStripMenuItemClassReport.Name = "ToolStripMenuItemClassReport";
            ToolStripMenuItemClassReport.Size = new Size(150, 22);
            ToolStripMenuItemClassReport.Text = "Sınıf Rapor";
            ToolStripMenuItemClassReport.Click += ToolStripMenuItemClassReport_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripDropDownButtonEducation
            // 
            toolStripDropDownButtonEducation.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButtonEducation.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemEducationCrud });
            toolStripDropDownButtonEducation.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripDropDownButtonEducation.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButtonEducation.Name = "toolStripDropDownButtonEducation";
            toolStripDropDownButtonEducation.Size = new Size(113, 22);
            toolStripDropDownButtonEducation.Text = "Eğitim İşlemleri";
            toolStripDropDownButtonEducation.ToolTipText = "Sınıf İşlemleri";
            // 
            // ToolStripMenuItemEducationCrud
            // 
            ToolStripMenuItemEducationCrud.Name = "ToolStripMenuItemEducationCrud";
            ToolStripMenuItemEducationCrud.Size = new Size(174, 22);
            ToolStripMenuItemEducationCrud.Text = "Ekle/Güncelle/Sil";
            ToolStripMenuItemEducationCrud.Click += ekleGüncelleSilToolStripMenuItem1_Click;
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(884, 761);
            Controls.Add(toolStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "AdministratorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiForm";
            Load += YoneticiForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton toolStripSplitButtonUser;
        private ToolStripMenuItem ToolStripMenuItemAdd;
        private ToolStripMenuItem ToolStripMenuItemUpdateDelete;
        private ToolStripDropDownButton toolStripDropDownBranch;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton toolStripDropDownButtonEducation;
        private ToolStripMenuItem ToolStripMenuItemBranchCrud;
        private ToolStripMenuItem ToolStripMenuItemEducationCrud;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton toolStripDropDownButtonReport;
        private ToolStripMenuItem RaporToolStripMenuItemGeneralReport;
        private ToolStripMenuItem ToolStripMenuItemBranchReport;
        private ToolStripMenuItem ToolStripMenuItemClassReport;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripDropDownButton toolStripDropDownButtonClass;
        private ToolStripMenuItem ekleGüncelleSilToolStripMenuItem;
    }
}