using System.Windows.Forms;

namespace PDFReporter.PDFControls
{
    public abstract class PDFControlBase
    {
        public string Name { get; set; }
        public float X_Coord { get; set; }
        public float Y_Coord { get; set; }
        public Control winFormControl { get; set; }

        public PDFControlBase(float x, float y, string Name)
        {
            X_Coord = x;
            Y_Coord = y;
            this.Name = Name;
        }
    }
}
