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
    public partial class MiscellaneousShapeTees : object
    {

        private MiscellaneousShapeTeesMiscellaneousShapeTee[] _itemsField;

        /// <remarks/>
        [XmlElement("MiscellaneousShapeTee", Form = XmlSchemaForm.Unqualified)]
        public MiscellaneousShapeTeesMiscellaneousShapeTee[] Items
        {
            get
            {
                return _itemsField;
            }
            set
            {
                _itemsField = value;

            }
        }
    }

    /// <remarks/>

    [Serializable()]
    [DebuggerStepThrough()]

    [XmlType(AnonymousType = true)]
    public partial class MiscellaneousShapeTeesMiscellaneousShapeTee : object
    {
        private string sizeField;
        private double aField;
        private double dField;
        private double twField;
        private double bfField;
        private double tfField;
        private double k_desField;
        private double k_detField;
        private double gageField;
        private double wt__ftField;
        private double bf__2_tfField;
        private double d_twField;
        private double ixField;
        private double sxField;
        private double rxField;
        private double y_barField;
        private double zxField;
        private double ypField;
        private double iyField;
        private double syField;
        private double _ryField;
        private double _zyField;
        private double _qsField;
        private double _jField;
        private double _cwField;
        private double _roBarField;
        private double _hField;

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
        public double d_tw
        {
            get
            {
                return d_twField;
            }
            set
            {
                d_twField = value;

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
        public double y_bar
        {
            get
            {
                return y_barField;
            }
            set
            {
                y_barField = value;

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
        public double yp
        {
            get
            {
                return ypField;
            }
            set
            {
                ypField = value;

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
                return _ryField;
            }
            set
            {
                _ryField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Zy
        {
            get
            {
                return _zyField;
            }
            set
            {
                _zyField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Qs
        {
            get
            {
                return _qsField;
            }
            set
            {
                _qsField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double J
        {
            get
            {
                return _jField;
            }
            set
            {
                _jField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Cw
        {
            get
            {
                return _cwField;
            }
            set
            {
                _cwField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double ro_bar
        {
            get
            {
                return _roBarField;
            }
            set
            {
                _roBarField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double H
        {
            get
            {
                return _hField;
            }
            set
            {
                _hField = value;

            }
        }
    }
}