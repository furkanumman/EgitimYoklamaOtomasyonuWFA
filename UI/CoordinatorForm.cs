using DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CoordinatorForm : Form
    {
        BranchReportForm branchReportForm = new BranchReportForm();
        Form1 mainForm;
        Coordinator arrivalCoordinator;
        public CoordinatorForm(Form1 frm, Coordinator coordinator)
        {
            mainForm = frm;
            arrivalCoordinator = coordinator;
            InitializeComponent();

        }

        private void CoordinatorForm_Load(object sender, EventArgs e)
        {
            ChildFormAc(new BranchReportForm(arrivalCoordinator));
        }
        void ChildFormAc(Form child)
        {
            bool IsOpen = false;
            foreach (Form mdiChild in MdiChildren)
            {
                if (mdiChild.Text == child.Text)
                {
                    IsOpen = true;
                    mdiChild.Activate();
                }
                else
                    mdiChild.Close();
            }

            if (!IsOpen)
            {
                child.StartPosition = FormStartPosition.Manual;
                child.Location = new Point((this.Width - child.Width) / 2, 0);
                child.MdiParent = this;
                child.Show();
            }
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            //ChildFormAc(new EducatorForm());
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            ChildFormAc(new ClassroomCrudForm(arrivalCoordinator));
        }

        private void branchReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormAc(new BranchReportForm(arrivalCoordinator));
        }

        private void classroomReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormAc(new ClassroomReportForm());
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormAc(new UserInsertForm());
        }
    }
}
