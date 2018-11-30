using System.Xml.Serialization;
using System;

namespace JobInvoicerCS
{
    [Serializable]
    public class Sequence
    {
        #region Public Properties
        [XmlAttribute("Number")]
        public int Number { get; set; }

        [XmlAttribute("Quantity")]
        public int Quantity { get; set; }

        #endregion
    }
}
