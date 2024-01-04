using DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class EducatorForm : Form
    {
        Form1 mainForm;
        Educator arrivalEducator;
        public EducatorForm(Form1 frm, Educator educator)
        {
            mainForm = frm;
            arrivalEducator = educator;
            InitializeComponent();
        }

        private void EducatorForm_Load(object sender, EventArgs e)
        {
            ChildFormAc(new AttendanceForm(arrivalEducator));
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

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            ChildFormAc(new AttendanceForm());
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            ChildFormAc(new ClassroomReportForm());
        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {
            //ChildFormAc(new AttendanceForm());
        }
    }
}
