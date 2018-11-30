using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace JobInvoicerCS
{
    [Serializable]
    public class Sheet
    {
        #region Public Methods

        public void GetDetails(StreamReader reader, Bill bill)
        {
            var detailCount = 0;
            var sequenceCount = 0;
            if (NumberOfDetails == 0)
                return;

            for (var i = 0; i < NumberOfDetails; i++)
            {
                var detail = new Detail();
                string line;
                int tempInt;
                while (detailCount < 2 && (line = reader.ReadLine()) != null)
                {
                    switch (detailCount)
                    {
                        default:
                            detail.Piecemark = line;
                            break;
                        case 1:
                            detail.NumberOfBillLines = int.TryParse(line, out tempInt) ? tempInt : 0;
                            break;
                    }
                    detailCount++;
                }

                while (sequenceCount < bill.NumberOfSequences && (line = reader.ReadLine()) != null)
                {
                    detail.Sequences.Add(new Sequence
                    {
                        Number = sequenceCount + 1,
                        Quantity = int.TryParse(line, out tempInt) ? tempInt : 0
                    });
                    sequenceCount++;
                }

                detail.GetBillLines(reader, bill);
                Details.Add(detail);
                sequenceCount = 0;
                detailCount = 0;
            }
        }

        #endregion

        #region Public Properties

        [XmlAttribute("Name")]
        public string Name { get; set; } = string.Empty;

        [XmlAttribute("NumberOfDetails")]
        public int NumberOfDetails { get; set; }

        [XmlElement("Detail")]
        //public List<Detail> Details=new List<Detail>();
        public List<Detail> Details { get; set; } = new List<Detail>();

        #endregion
    }
}