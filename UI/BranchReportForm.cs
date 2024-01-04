using BLL.Services;
using BLL.Services.ReportServices;
using DATA;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace UI
{
    public partial class BranchReportForm : Form
    {
        BranchService branchService;
        BranchReportService branchReportService;
        Coordinator arrivalCoordinator;

        public BranchReportForm()
        {
            InitializeComponent();
        }

        public BranchReportForm(Coordinator coordinator)
        {
            arrivalCoordinator = coordinator;
            InitializeComponent();


        }

        private void btnPDFKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSubeSec.SelectedIndex != -1)
                {
                    PdfDocument pdf = new PdfDocument();
                    PdfPage page = pdf.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont titleFont = new XFont("Arial", 24, XFontStyle.Bold);
                    XFont topicFont = new XFont("Times New Roman", 16);

                    gfx.DrawString("ŞUBE RAPORU", titleFont, XBrushes.Black, new XRect(0, 20, page.Width, page.Height), XStringFormats.TopCenter);
                    gfx.DrawString($"{lblTextKoordinatorSayisi.Text} {lblKoordinatorSayisi.Text}", topicFont, XBrushes.Black, new XRect(30, 60, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"{lblTextEgitmenSayisi.Text} {lblEgitmenSayisi.Text}", topicFont, XBrushes.Black, new XRect(30, 90, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"{lblTextOgrenciSayisi.Text} {lblKoordinatorSayisi.Text}", topicFont, XBrushes.Black, new XRect(30, 120, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"{lblTextEgitimSayisi.Text} {lblEgitimSayisi.Text}", topicFont, XBrushes.Black, new XRect(30, 150, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"{lblTextVerilenDersSaati.Text} {lblVerilenDersSaati.Text}", topicFont, XBrushes.Black, new XRect(30, 180, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"{lblTextVerilenDersEgitmenOrtalamasi.Text} {lblDersEgitmenOrtalamasi.Text}", topicFont, XBrushes.Black, new XRect(30, 210, page.Width, page.Height), XStringFormats.TopLeft);

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PDF Dosyası|*.pdf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pdf.Save(saveFileDialog.FileName);
                        MessageBox.Show("PDF dosyası kaydedildi.");
                        cmbSubeSec.SelectedIndex = -1;
                        ComponentControl.ControlClean(grpSubeRaporu);
                    }
                }
                else
                    MessageBox.Show("Lütfen şube seçimi yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IOException)
            {
                MessageBox.Show("Kaydetmek istediğiniz pdf dosyası açıktır.\nDosyayı kapatıp tekrar kaydediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BranchReportForm_Load(object sender, EventArgs e)
        {
            branchService = new BranchService();
            branchReportService = new BranchReportService();

            // Şube ComboBox'ı doldurduk.
            ComponentControl.FillWithBranch(cmbSubeSec);

            if (arrivalCoordinator != null)
            {
                string branchName = branchService.GetBranchNameByID(arrivalCoordinator.BranchID);
                cmbSubeSec.Text = branchName;
                cmbSubeSec.Enabled = false;
            }



        }

        private void cmbSubeSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubeSec.SelectedIndex == -1)
                return;

            // Şube ID'sini bulduk.
            int branchID = branchService.GetBranchIDByName(cmbSubeSec.Text);

            // Labelları doldurduk.

            lblKoordinatorSayisi.Text = branchReportService.CoordinatorCountByID(branchID).ToString();
            lblEgitmenSayisi.Text = branchReportService.EducatorCountByID(branchID).ToString();
            lblOgrenciSayisi.Text = branchReportService.StudentCountByID(branchID).ToString();
            lblEgitimSayisi.Text = branchReportService.EducationCountByID(branchID).ToString();
            lblVerilenDersSaati.Text = branchReportService.TotalEducationDuration(branchID).ToString();
            try
            {
                lblDersEgitmenOrtalamasi.Text = branchReportService.EducationAmountPerEducator(branchID).ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Şubeye ait eğitmen kaydı bulunmamaktadır!", "Uyarı");
            }
            finally
            {
                lblDersEgitmenOrtalamasi.Text = "n/a";
            }
        }
    }
}
