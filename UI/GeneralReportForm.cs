using BLL.Services.ReportServices;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace UI
{
    public partial class GeneralReportForm : Form
    {
        public GeneralReportForm()
        {
            InitializeComponent();
        }

        private void GeneralReportForm_Load(object sender, EventArgs e)
        {
            GeneralReportService generalReportService = new();

            int adminCount = generalReportService.CountAdministrator();
            lblYoneticiSayisi.Text = adminCount.ToString();

            int branchCount = generalReportService.CountBranch();
            lblSubeSayisi.Text = branchCount.ToString();

            int coordinatorCount = generalReportService.CountCoordinator();
            lblKoordinatorSayisi.Text = coordinatorCount.ToString();

            int educatorCount = generalReportService.CountEducator();
            lblEgitmenSayisi.Text = educatorCount.ToString();

            int studentCount = generalReportService.CountStudent();
            lblOgrenciSayisi.Text = studentCount.ToString();

            int educationCount = generalReportService.CountEducation();
            lblEgitimSayisi.Text = educationCount.ToString();

            int educationTotalDuration = generalReportService.TotalEducationDuration();
            lblDersSaati.Text = educationTotalDuration.ToString();

            lblSubeDersOrtalamasi.Text = (Convert.ToDouble(educationCount) / branchCount).ToString();

            double islem1 = (Convert.ToDouble(educationCount) / educatorCount);
            lblEgitmenDersOrtalamasi.Text = islem1.ToString();
        }

        private void btnPDFKaydet_Click(object sender, EventArgs e)
        {
            PdfDocument pdf = new PdfDocument();

            PdfPage page = pdf.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont titleFont = new XFont("Arial", 20,XFontStyle.Bold);
            XFont topicFont = new XFont("Times New Roman", 16);

            gfx.DrawString("GENEL RAPOR", titleFont, XBrushes.Black, new XRect(0, 20, page.Width, page.Height), XStringFormats.TopCenter);
            gfx.DrawString($"Yönetici Sayısı : {lblYoneticiSayisi.Text}", topicFont, XBrushes.Black, new XRect(30, 60, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Şube Sayısı : {lblSubeSayisi.Text}", topicFont, XBrushes.Black, new XRect(30, 90, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Koordinatör Sayısı : {lblKoordinatorSayisi.Text}", topicFont, XBrushes.Black, new XRect(30, 120, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Eğitmen Sayısı : {lblEgitmenSayisi.Text}", topicFont, XBrushes.Black, new XRect(30, 150, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Öğrenci Sayısı : {lblOgrenciSayisi.Text}", topicFont, XBrushes.Black, new XRect(30, 180, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Eğitim Sayısı : {lblEgitimSayisi.Text}", topicFont, XBrushes.Black, new XRect(30, 210, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Verilen Ders Saati : {lblDersSaati.Text}", topicFont, XBrushes.Black, new XRect(30, 240, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Verilen Ders / Şube Ortalaması : {lblSubeDersOrtalamasi.Text}", topicFont, XBrushes.Black, new XRect(30, 270, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Verilen Ders / Eğitmen Ortalaması : {lblEgitmenDersOrtalamasi.Text}", topicFont, XBrushes.Black, new XRect(30, 300, page.Width, page.Height), XStringFormats.TopLeft);
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Dosyası|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pdf.Save(saveFileDialog.FileName);
                MessageBox.Show("PDF dosyası kaydedildi.");
            }
        }

    }
}
