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
    public partial class TubeSteels : object
    {

        private TubeSteelsTubeSteel[] itemsField;

        /// <remarks/>
        [XmlElement("TubeSteel", Form = XmlSchemaForm.Unqualified)]
        public TubeSteelsTubeSteel[] Items
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
    public partial class TubeSteelsTubeSteel : object
    {

        private string sizeField;

        private double aField;

        private double hField;

        private double bField;

        private double t_nomField;

        private double t_desField;

        private double wt__ftField;

        private double b_tField;

        private double h_tField;

        private double ixField;

        private double sxField;

        private double rxField;

        private double zxField;

        private double iyField;

        private double syField;

        private double ryField;

        private double zyField;

        private double h_flatField;

        private double b_flatField;

        private double jField;

        private double cField;

        private double a_surfField;

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
        public double h
        {
            get
            {
                return hField;
            }
            set
            {
                hField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double b
        {
            get
            {
                return bField;
            }
            set
            {
                bField = value;

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
        public double b_t
        {
            get
            {
                return b_tField;
            }
            set
            {
                b_tField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double h_t
        {
            get
            {
                return h_tField;
            }
            set
            {
                h_tField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Ix
        {
            get
            {
                return ixField;
            }
            set
            {
                ixField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Sx
        {
            get
            {
                return sxField;
            }
            set
            {
                sxField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double rx
        {
            get
            {
                return rxField;
            }
            set
            {
                rxField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Zx
        {
            get
            {
                return zxField;
            }
            set
            {
                zxField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Iy
        {
            get
            {
                return iyField;
            }
            set
            {
                iyField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Sy
        {
            get
            {
                return syField;
            }
            set
            {
                syField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double ry
        {
            get
            {
                return ryField;
            }
            set
            {
                ryField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Zy
        {
            get
            {
                return zyField;
            }
            set
            {
                zyField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double h_flat
        {
            get
            {
                return h_flatField;
            }
            set
            {
                h_flatField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double b_flat
        {
            get
            {
                return b_flatField;
            }
            set
            {
                b_flatField = value;

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

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double A_surf
        {
            get
            {
                return a_surfField;
            }
            set
            {
                a_surfField = value;

            }
        }
    }
}