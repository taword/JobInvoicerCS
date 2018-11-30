using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace JobInvoicerCS
{
    [Serializable]
    public enum UnitOfMeasurement
    {
        Imperial = 0,
        Metric = 1
    }

    [Serializable]
    public class Bill
    {
        #region Private Fields

        private string _internalJob;
        private UnitOfMeasurement _unitOfMeasurement;
        private List<Sheet> _sheets = new List<Sheet>();
        #endregion

        #region Public Properties
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Job")]
        public string Job { get; set; }

        //[XmlAttribute("InternalJob")]
        

        public string InternalJob
        {
            get { return _internalJob; }
            set { _internalJob = value; }
        }

        [XmlAttribute("InternalLocation")]
        public string InternalLocation { get; set; }

        [XmlAttribute("UnitOfMeasurement")]
        public UnitOfMeasurement UnitOfMeasurement
        {
            get { return _unitOfMeasurement; }
            set { _unitOfMeasurement = value; }
        }

        [XmlAttribute("DefaultDiameter")]
        public double DefaultDiameter { get; set; }

        [XmlAttribute("BoltType")]
        public string BoltType { get; set; }

        [XmlAttribute("NumberOfSequences")]
        public int NumberOfSequences { get; set; }

        [XmlAttribute("NumberOfSheets")]
        public int NumberOfSheets { get; set; }

        [XmlElement("Sheet")]
        public List<Sheet> Sheets
        {
            get { return _sheets; }
            set { _sheets = value; }
        }
        #endregion

        #region Private Methods
        /// <summary>
        ///     Develops the File Header from the output text.
        ///     The first 9 lines of the BIF are the file header.
        /// </summary>
        private void GetHeader(StreamReader reader)
        {
            string line;
            var headerCount = 0;
            while (headerCount < 9 && (line = reader.ReadLine()) != null)
            {
                int tempInt;
                switch (headerCount)
                {
                    default:
                        Name = line;
                        break;
                    case 1:
                        Job = line;
                        break;
                    case 2:
                        InternalJob = line;
                        break;
                    case 3:
                        InternalLocation = line;
                        break;
                    case 4:
                        UnitOfMeasurement = int.TryParse(line, out tempInt) ? (UnitOfMeasurement) tempInt : 0;
                        break;
                    case 5:
                        double tempDouble;
                        DefaultDiameter = double.TryParse(line, out tempDouble) ? tempDouble : 0;
                        break;
                    case 6:
                        BoltType = line;
                        break;
                    case 7:
                        NumberOfSequences = int.TryParse(line, out tempInt) ? tempInt : 0;
                        break;
                    case 8:
                        NumberOfSheets = int.TryParse(line, out tempInt) ? tempInt : 0;
                        break;
                }
                headerCount++;
            }
            GetSheets(reader);
        }

        /// <summary>
        ///     Using the number of sheets from the header,
        ///     parses text to find all the sheets
        /// </summary>
        private void GetSheets(StreamReader reader)
        {
            var sheetCount = 0;
            if (NumberOfSheets == 0) return;
            for (var i = 0; i < NumberOfSheets; i++)
            {
                var sheet = new Sheet();
                string line;
                while (sheetCount < 2 && (line = reader.ReadLine()) != null)
                {

                    if (sheetCount == 0)
                        sheet.Name = line;
                    else
                    {
                        int tempInt;
                        sheet.NumberOfDetails = int.TryParse(line, out tempInt) ? tempInt : 0;
                    }

                    sheetCount++;
                }
                sheet.GetDetails(reader, this);
                Sheets.Add(sheet);
                sheetCount = 0;
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        ///     Generates the XML
        /// </summary>
        public void GenerateXml(string fileName)
        {
            GenerateXml(new FileInfo(fileName));
        }

        /// <summary>
        ///     Serializes the input file to XML
        /// </summary>
        private void GenerateXml(FileInfo file)
        {
            var serializer = new XmlSerializer(typeof(Bill));
            var xsns = new XmlSerializerNamespaces(new[] { new XmlQualifiedName("", "") });
            using (TextWriter writer = new StreamWriter(file.FullName))
                serializer.Serialize(writer, this, xsns);
        }

        public void Parse(string fileName)
        {
            Parse(new FileInfo(fileName));
        }

        public void Parse(FileInfo file)
        {
            if (!file.Exists) return;
            using (var reader = new StreamReader(file.FullName))
                Parse(reader);
        }

        private void Parse(StreamReader reader)
        {
            GetHeader(reader);
        }
        #endregion
    }
}