namespace UI
{
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormAc(new UserInsertForm());
        }

        private void YoneticiForm_Load(object sender, EventArgs e)
        {
            ChildFormAc(new GeneralReportForm());
        }

        private void guncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormAc(new UserUpdateForm());
        }

        private void genelRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormAc(new GeneralReportForm());
        }

        private void ekleGüncelleSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChildFormAc(new EducationCrudForm());
        }

        private void ekleGüncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormAc(new BranchCrudForm());
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

        private void ekleGüncelleSilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChildFormAc(new ClassroomCrudForm());
        }

        private void ToolStripMenuItemBranchReport_Click(object sender, EventArgs e)
        {
            ChildFormAc(new BranchReportForm());
        }

        private void ToolStripMenuItemClassReport_Click(object sender, EventArgs e)
        {
            ChildFormAc(new ClassroomReportForm());
        }
    }
}
