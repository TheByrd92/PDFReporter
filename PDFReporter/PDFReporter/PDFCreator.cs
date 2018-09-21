using PDFReporter.PDFControls;
using Root.Reports;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
                    if (itm.GetType().Equals(typeof(PDFLabel)))
                    {
                        mainVisualizer.GetMainPanel().Controls.Add(itm.winFormControl);
                    }
                    else if(itm.GetType().Equals(typeof(PDFLine)))
                    {
                        Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
                        PDFLine tempLine = (PDFLine)itm;
                        using (var e = mainVisualizer.GetMainPanel().CreateGraphics())
                        {
                            e.DrawLine(pen, tempLine.X_Coord, tempLine.Y_Coord, tempLine.endX, tempLine.endY + tempLine.Y_Coord);
                        }
                    }
                }
            }
        }

        public FontDef fd;
        public void CreatePDFObjects()
        {
            FontDef fdNew;
            foreach (var itm in pdfCtrls)
            {
                if (itm.GetType().Equals(typeof(PDFLabel)))
                {
                    PDFLabel tempPDFLbl = (PDFLabel)itm;
                    try
                    {
                        fdNew = new FontDef(rpt, tempPDFLbl.FontNameType);
                        fd = fdNew;
                    }
                    catch
                    {

                    }
                    FontProp fp = new FontPropMM(fd, tempPDFLbl.FontSize/10);
                    page.Add(tempPDFLbl.X_Coord, tempPDFLbl.Y_Coord, new RepString(fp, tempPDFLbl.Text));
                }
                else if (itm.GetType().Equals(typeof(PDFLine)))
                {
                    PDFLine tempPDFLine = (PDFLine)itm;
                    PenProp pp = new PenProp(rpt, tempPDFLine.thickness);
                    page.Add(tempPDFLine.X_Coord, tempPDFLine.Y_Coord, new RepLine(pp, tempPDFLine.endX, tempPDFLine.endY));
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
