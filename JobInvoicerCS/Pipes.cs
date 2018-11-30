using System;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace JobInvoicerCS
{
    /// <remarks/>

    [Serializable()]
    [DebuggerStepThrough()]

    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Pipes : object
    {

        private PipesPipe[] itemsField;

        /// <remarks/>
        [XmlElement("Pipe", Form = XmlSchemaForm.Unqualified)]
        public PipesPipe[] Items
        {
            get
            {
                return itemsField;
            }
            set
            {
                itemsField = value;

            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [DebuggerStepThrough()]

    [XmlType(AnonymousType = true)]
    public partial class PipesPipe : object
    {

        private string sizeField;

        private double aField;

        private double odField;

        private double idField;

        private double t_nomField;

        private double t_desField;

        private double wt__ftField;

        private double d_tField;

        private double iField;

        private double sField;

        private double rField;

        private double zField;

        private double jField;

        private double cField;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Size
        {
            get
            {
                return sizeField;
            }
            set
            {
                sizeField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double A
        {
            get
            {
                return aField;
            }
            set
            {
                aField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double OD
        {
            get
            {
                return odField;
            }
            set
            {
                odField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double t_nom
        {
            get
            {
                return t_nomField;
            }
            set
            {
                t_nomField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double t_des
        {
            get
            {
                return t_desField;
            }
            set
            {
                t_desField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double wt__ft
        {
            get
            {
                return wt__ftField;
            }
            set
            {
                wt__ftField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double D_t
        {
            get
            {
                return d_tField;
            }
            set
            {
                d_tField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double I
        {
            get
            {
                return iField;
            }
            set
            {
                iField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double S
        {
            get
            {
                return sField;
            }
            set
            {
                sField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double r
        {
            get
            {
                return rField;
            }
            set
            {
                rField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Z
        {
            get
            {
                return zField;
            }
            set
            {
                zField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double J
        {
            get
            {
                return jField;
            }
            set
            {
                jField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double C
        {
            get
            {
                return cField;
            }
            set
            {
                cField = value;

            }
        }
    }
}