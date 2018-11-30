using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace JobInvoicerCS
{
    public class Detail
    {
        #region Public Methods

        public void GetBillLines(StreamReader reader, Bill bill)
        {
            var lineCount = 0;
            if (NumberOfBillLines == 0)
                return;

            for (var i = 0; i < NumberOfBillLines; i++)
            {
                var    billLine = new Line {Number = i + 1};
                string line;
                while (lineCount < 10 && (line = reader.ReadLine()) != null)
                {
                    int    tempInt;
                    double tempDouble;
                    switch (lineCount)
                    {
                        default:
                            billLine.TotalQuantity = int.TryParse(line, out tempInt) ? tempInt : 0;
                            break;
                        case 1:
                            billLine.UnitQuantity = int.TryParse(line, out tempInt) ? tempInt : 0;
                            break;
                        case 2:
                            billLine.Material = line;
                            break;
                        case 3:
                            billLine.SteelGrade = line;
                            break;
                        case 4:
                            billLine.Length = double.TryParse(line, out tempDouble) ? tempDouble : 0;
                            break;
                        case 5:
                            billLine.MinorMark = line;
                            break;
                        case 6:
                            billLine.UnitWeight = double.TryParse(line, out tempDouble) ? tempDouble : 0;
                            break;
                        case 7:
                            billLine.TotalWeight = double.TryParse(line, out tempDouble) ? tempDouble : 0;
                            break;
                        case 8:
                            billLine.Remarks = line;
                            break;
                        case 9:
                            billLine.AdvanceMill = line;
                            break;
                    }

                    lineCount++;
                }

                Lines.Add(billLine);
                lineCount = 0;
            }
        }

        #endregion

        #region Public Properties

        [XmlAttribute("Piecemark")]
        public string Piecemark { get; set; } = string.Empty;

        [XmlAttribute("NumberOfBillLines")]
        public int NumberOfBillLines { get; set; }

        [XmlElement("Sequence")]
        public List<Sequence> Sequences { get; } = new List<Sequence>();

        [XmlElement("BillLine")]
        public List<Line> Lines { get; set; } = new List<Line>();

        #endregion
    }
}