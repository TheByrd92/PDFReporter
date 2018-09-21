using System.Windows.Forms;

namespace PDFReporter
{
    public partial class Visualizer : Form
    {
        
        public Visualizer()
        {
            InitializeComponent();
        }

        public Panel GetMainPanel()
        {
            return MainPanel;
        }

        private void previewBtn_Click(object sender, System.EventArgs e)
        {
            using (var pdfCrtr = new PDFCreator(this, "Example"))
            {
                pdfCrtr.AddPDFControl(new PDFControls.PDFLabel(20, 20, "Look at this!"));
                pdfCrtr.AddPDFControl(new PDFControls.PDFLine(10, 100, 260, 100.0f));
                pdfCrtr.AddPDFControl(new PDFControls.PDFLabel(20, 150, "And This!"));
                pdfCrtr.CreatePDFObjects();
                pdfCrtr.PreviewItems();
                pdfCrtr.ViewReport();
            }
        }

        private void bindingSource1_CurrentChanged(object sender, System.EventArgs e)
        {

        }
    }
}
