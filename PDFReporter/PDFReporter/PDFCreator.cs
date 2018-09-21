using PDFReporter.PDFControls;
using Root.Reports;
using System;
using System.Collections.Generic;

namespace PDFReporter
{
    public class PDFCreator : IDisposable
    {
        private List<PDFControlBase> pdfCtrls = new List<PDFControlBase>();
        private Visualizer mainVisualizer;
        private Report rpt = new Report(new PdfFormatter());
        private Page page;
        private string pdfName = "example.pdf";
        
        public PDFCreator(Visualizer mainVisualizer, string pdfName)
        {
            this.mainVisualizer = mainVisualizer;
            this.pdfName = (pdfName.Contains(".pdf") ? pdfName : pdfName + ".pdf");
            page = new Page(rpt);
        }

        public void AddPDFControl(PDFControlBase pdfCtrl)
        {
            pdfCtrls.Add(pdfCtrl);
        }

        public void PreviewItems()
        {
            mainVisualizer.GetMainPanel().Controls.Clear();
            foreach (var itm in pdfCtrls)
            {
                if(itm != null)
                {
                    mainVisualizer.GetMainPanel().Controls.Add(itm.winFormControl);
                }
            }
        }

        public void CreatePDFObjects()
        {
            foreach (var itm in pdfCtrls)
            {
                if (itm.GetType().Equals(typeof(PDFLabel)))
                {
                    PDFLabel tempPDFLbl = (PDFLabel)itm;
                    FontDef fd = new FontDef(rpt, tempPDFLbl.FontNameType);
                    FontProp fp = new FontPropMM(fd, tempPDFLbl.FontSize/10);
                    page.Add(tempPDFLbl.X_Coord, tempPDFLbl.Y_Coord, new RepString(fp, tempPDFLbl.Text));
                }
            }
        }

        public void ViewReport()
        {
            RT.ViewPDF(rpt, pdfName);
        }

        public void Dispose()
        {
            pdfCtrls.Clear();
            pdfCtrls = null;
            rpt = null;
            page = null;
            pdfName = null;
        }
    }
}
