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
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DoubleAngles : object
    {

        private DoubleAnglesDoubleAngle[] _itemsField;

        /// <remarks/>
        [XmlElement("DoubleAngle", Form = XmlSchemaForm.Unqualified)]
        public DoubleAnglesDoubleAngle[] Items
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
    public class DoubleAnglesDoubleAngle : object
    {

        private string _sizeField;

        private double _aField;

        private double _dField;

        private double _bField;

        private double _tField;

        private double _wtFtField;

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

        private double _roBarField;

        private double _hField;

        private double _qsField;

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
        public double B
        {
            get
            {
                return _bField;
            }
            set
            {
                _bField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double T
        {
            get
            {
                return _tField;
            }
            set
            {
                _tField = value;
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
    }
}