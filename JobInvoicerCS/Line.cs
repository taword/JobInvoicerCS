using System.Xml.Serialization;
using System;

namespace JobInvoicerCS
{
    /// <summary>
    ///     Each bill lines contains:
    ///         Line Number = Number
    ///         Total Quantity = 
    ///         Unit Quantity
    ///         Description
    ///         Steel Grade
    ///         Length (in double inch/mm)
    ///         Minor Mark
    ///         Unit Weight
    ///         Total Weight (of line: Unit Weight x Total Quantity = Total Weight)
    ///         Remarks, Advance Mill #, and/or Steel Grade
    ///         Advance Mill #
    /// </summary>
    [Serializable]
    public class Line
    {
        #region Public Properties
        [XmlAttribute("Number")]
        public int Number { get; set; }

        [XmlElement("TotalQuantity")]
        public int TotalQuantity { get; set; }

        [XmlElement("UnitQuantity")]
        public int UnitQuantity { get; set; }

        [XmlElement("Material")]
        public string Material { get; set; } = string.Empty;

        [XmlElement("SteelGrade")]
        public string SteelGrade { get; set; } = string.Empty;

        [XmlElement("Length")]
        public double Length { get; set; }

        [XmlElement("MinorMark")]
        public string MinorMark { get; set; } = string.Empty;

        [XmlElement("UnitWeight")]
        public double UnitWeight { get; set; }

        [XmlElement("TotalWeight")]
        public double TotalWeight { get; set; }

        [XmlElement("Remarks")]
        public string Remarks { get; set; } = string.Empty;

        [XmlElement("AdvanceMill")]
        public string AdvanceMill { get; set; } = string.Empty;

        #endregion
    }
}
