using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace JobInvoicerCS
{
    public class MbrSheet
    {
        public static readonly Dictionary<int, MbrSheet> MSheets = new Dictionary<int, MbrSheet>();

        private int _sheetId;

        public List<Member> Members { get; }

        public MbrSheet(int sheetId)
        {
            _sheetId = sheetId;
            Members = new List<Member>();
            
        }

        public static double WeightByType(string memberType)
        {
            //var wbt = 0D;
            //var subset = MSheets.Where(kvp => kvp.Value.Members.Count(m => m.MemberType == memberType) > 0);
            //var list = subset.ToList();
            //list.ForEach(
            //    kvp =>
            //    {
            //        wbt += kvp.Value.Members.Sum(m => Convert.ToDouble(m.TotalWeight, CultureInfo.InvariantCulture));
            //    });
            //return wbt;

            var totalSheetWeight = 0D;
            var subset = MSheets.Where(kvp => kvp.Value.Members.Any(m => m.MemberType == memberType));
            subset.ToList().ForEach(kvp => totalSheetWeight += (double) kvp.Value.Members.Sum(m => Convert.ToDecimal(m.TotalWeight, CultureInfo.InvariantCulture)));
            return totalSheetWeight;
            //wbt += MSheets
            // .Where(kvp => kvp.Value.Members.Count(m => m.MemberType == memberType) > 0)
            // .Sum(kvp => kvp.Value.Members.Sum(m => Convert.ToDouble(m.TotalWeight, CultureInfo.InvariantCulture)));
        }
    }
}