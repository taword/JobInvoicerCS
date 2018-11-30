using System;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace JobInvoicerCS
{
    /// <remarks/>

    [Serializable]
    [DebuggerStepThrough]

    [XmlType(AnonymousType = true)]
    [XmlRoot("S-ShapeTees", Namespace = "", IsNullable = false)]
    public class SShapeTees : object
    {

        private SShapeTeesSShapeTee[] _itemsField;

        /// <remarks/>
        [XmlElement("S-ShapeTee", Form = XmlSchemaForm.Unqualified)]
        public SShapeTeesSShapeTee[] Items
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

    [Serializable]
    [DebuggerStepThrough]

    [XmlType(AnonymousType = true)]
    public class SShapeTeesSShapeTee : object
    {

        private string _sizeField;

        private double _aField;

        private double _dField;

        private double _twField;

        private double _bfField;

        private double _tfField;

        private double _kDesField;

        private double _kDetField;

        private double _gageField;

        private double _wtFtField;

        private double _bf2TfField;

        private double _dTwField;

        private double _ixField;

        private double _sxField;

        private double _rxField;

        private double _yBarField;

        private double _zxField;

        private double _ypField;

        private double _iyField;

        private double _syField;

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
                return _sizeField;
            }
            set
            {
                _sizeField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double A
        {
            get
            {
                return _aField;
            }
            set
            {
                _aField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double D
        {
            get
            {
                return _dField;
            }
            set
            {
                _dField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Tw
        {
            get
            {
                return _twField;
            }
            set
            {
                _twField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Bf
        {
            get
            {
                return _bfField;
            }
            set
            {
                _bfField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Tf
        {
            get
            {
                return _tfField;
            }
            set
            {
                _tfField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double KDes
        {
            get
            {
                return _kDesField;
            }
            set
            {
                _kDesField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double KDet
        {
            get
            {
                return _kDetField;
            }
            set
            {
                _kDetField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Gage
        {
            get
            {
                return _gageField;
            }
            set
            {
                _gageField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double WtFt
        {
            get
            {
                return _wtFtField;
            }
            set
            {
                _wtFtField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Bf2Tf
        {
            get
            {
                return _bf2TfField;
            }
            set
            {
                _bf2TfField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double DTw
        {
            get
            {
                return _dTwField;
            }
            set
            {
                _dTwField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Ix
        {
            get
            {
                return _ixField;
            }
            set
            {
                _ixField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Sx
        {
            get
            {
                return _sxField;
            }
            set
            {
                _sxField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Rx
        {
            get
            {
                return _rxField;
            }
            set
            {
                _rxField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double YBar
        {
            get
            {
                return _yBarField;
            }
            set
            {
                _yBarField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Zx
        {
            get
            {
                return _zxField;
            }
            set
            {
                _zxField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Yp
        {
            get
            {
                return _ypField;
            }
            set
            {
                _ypField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Iy
        {
            get
            {
                return _iyField;
            }
            set
            {
                _iyField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Sy
        {
            get
            {
                return _syField;
            }
            set
            {
                _syField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Ry
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
        public double RoBar
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