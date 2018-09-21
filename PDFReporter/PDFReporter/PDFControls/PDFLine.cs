namespace PDFReporter.PDFControls
{
    public class PDFLine : PDFControlBase
    {

        public float endX { get; set; }
        public float endY { get; set; }
        public double thickness { get; set; }

        public PDFLine(float x, float y, float length, double thickness = 2, string Name = "", bool isHorizontal = true) : base(x, y, Name)
        {
            if (isHorizontal)
            {
                endX += length;
            }
            else
            {
                endY += length;
            }
            this.thickness = thickness;
        }

        public PDFLine(float x, float y, float endX, float endY, double thickness = 2, string Name = "") : base(x, y, Name)
        {
            this.endX = endX-x;
            this.endY = endY-y;
            this.thickness = thickness;
        }


    }
}
