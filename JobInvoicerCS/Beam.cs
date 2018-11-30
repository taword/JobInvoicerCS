namespace JobInvoicerCS
{
    public class Beam
    {
        #region "Constructors"

        //Default class Constructor
        protected Beam()
        {
            Piecemark    = string.Empty;
            MaterialSize = string.Empty;
            TotalWeight  = string.Empty;
            WeightType   = string.Empty;
            SheetKey     = 0;
            StructType   = string.Empty;
        }

        #endregion

        #region "Properties"

        public string Piecemark        { get; set; }
        public string TotalWeight      { get; set; }
        public string MaterialSize     { get; set; }
        public int    SheetKey         { get; set; }
        public string StructType       { get; set; }
        public string MemberSheetIndex { get; set; }
        public string WeightType       { get; set; }

        #endregion
    }
}