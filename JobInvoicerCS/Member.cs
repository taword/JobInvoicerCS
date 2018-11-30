namespace JobInvoicerCS
{
    public class Member
    {
        #region "Constructors"

        //Default class Constructor
        protected Member()
        {
            Piecemark   = string.Empty;
            MemberType  = string.Empty;
            Material    = string.Empty;
            Size        = string.Empty;
            TotalWeight = string.Empty;
            SheetKey    = 0;
            StructType  = string.Empty;
        }

        public Member(string piecemark,  string memberType,       string material, string size, string totalWeight,
                      string structType, string memberSheetIndex, int    sheetId)
        {
            Piecemark        = piecemark;
            MemberType       = memberType;
            Material         = material;
            Size             = size;
            TotalWeight      = totalWeight;
            StructType       = structType;
            MemberSheetIndex = memberSheetIndex;
            SheetKey         = sheetId;

            if (!MbrSheet.MSheets.ContainsKey(sheetId))
            {
                MbrSheet.MSheets.Add(sheetId, new MbrSheet(sheetId));
            }

            MbrSheet.MSheets[sheetId].Members.Add(this);
        }

        #endregion

        #region "Properties"

        public string Piecemark        { get; set; }
        public string MemberType       { get; private set; }
        public string TotalWeight      { get; private set; }
        public string Size             { get; set; }
        public int    SheetKey         { get; set; }
        public string Material         { get; set; }
        public string StructType       { get; set; }
        public string MemberSheetIndex { get; set; }

        #endregion
    }
}