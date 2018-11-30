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
    [XmlRoot("S-Shapes", Namespace = "", IsNullable = false)]
    public partial class SShapes : object
    {

        private SShapesSShape[] itemsField;

        /// <remarks/>
        [XmlElement("S-Shape", Form = XmlSchemaForm.Unqualified)]
        public SShapesSShape[] Items
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
    public partial class SShapesSShape : object
    {

        private string sizeField;

        private double aField;

        private double dField;

        private double twField;

        private double bfField;

        private double tfField;

        private double k_desField;

        private double k_detField;

        private double k1Field;

        private double tField;

        private double gageField;

        private double wt__ftField;

        private double bf__2_tfField;

        private double h_twField;

        private double ixField;

        private double sxField;

        private double rxField;

        private double zxField;

        private double iyField;

        private double syField;

        private double ryField;

        private double zyField;

        private double rtsField;

        private double hoField;

        private double jField;

        private double cwField;

        private double wnoField;

        private double sw1Field;

        private double qfField;

        private double qwField;

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
        public double d
        {
            get
            {
                return dField;
            }
            set
            {
                dField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double tw
        {
            get
            {
                return twField;
            }
            set
            {
                twField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double bf
        {
            get
            {
                return bfField;
            }
            set
            {
                bfField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double tf
        {
            get
            {
                return tfField;
            }
            set
            {
                tfField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double k_des
        {
            get
            {
                return k_desField;
            }
            set
            {
                k_desField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double k_det
        {
            get
            {
                return k_detField;
            }
            set
            {
                k_detField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double k1
        {
            get
            {
                return k1Field;
            }
            set
            {
                k1Field = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double T
        {
            get
            {
                return tField;
            }
            set
            {
                tField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double gage
        {
            get
            {
                return gageField;
            }
            set
            {
                gageField = value;

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
        public double bf__2_tf
        {
            get
            {
                return bf__2_tfField;
            }
            set
            {
                bf__2_tfField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double h_tw
        {
            get
            {
                return h_twField;
            }
            set
            {
                h_twField = value;

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
        public double rts
        {
            get
            {
                return rtsField;
            }
            set
            {
                rtsField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double ho
        {
            get
            {
                return hoField;
            }
            set
            {
                hoField = value;

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
        public double Cw
        {
            get
            {
                return cwField;
            }
            set
            {
                cwField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Wno
        {
            get
            {
                return wnoField;
            }
            set
            {
                wnoField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Sw1
        {
            get
            {
                return sw1Field;
            }
            set
            {
                sw1Field = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Qf
        {
            get
            {
                return qfField;
            }
            set
            {
                qfField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Qw
        {
            get
            {
                return qwField;
            }
            set
            {
                qwField = value;

            }
        }
    }
}