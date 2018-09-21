using Root.Reports;
using System.Windows.Forms;

namespace PDFReporter.PDFControls
{
    public class PDFLabel : PDFControlBase
    {
        public string Text { get; set; }
        public double FontSize { get; set; }
        public FontDef.StandardFont FontNameType { get; set; }
        private Label winFormLbl = new Label();

        public PDFLabel(float x, float y, string Text, double FontSize = 12, FontDef.StandardFont FontNameType = FontDef.StandardFont.Courier, string Name = "") : base(x, y, Name)
        {
            this.Text = Text;
            this.FontSize = FontSize;
            this.FontNameType = FontNameType;
            winFormLbl.Location = new System.Drawing.Point((int)x, (int)y);
            winFormLbl.Text = Text;
            winFormLbl.Font = new System.Drawing.Font("Courier", (float)FontSize);
            winFormControl = winFormLbl;
        }
    }
}
