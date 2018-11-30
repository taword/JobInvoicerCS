using System;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;
// ReSharper disable InconsistentNaming

namespace JobInvoicerCS
{
    /// <remarks/>
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WideFlangeTees : object
    {

        private WideFlangeTeesWideFlangeTee[] _itemsField;

        /// <remarks/>
        [XmlElement("WideFlangeTee", Form = XmlSchemaForm.Unqualified)]
        public WideFlangeTeesWideFlangeTee[] Items
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
    public class WideFlangeTeesWideFlangeTee : object
    {
        private string _size;
        private double _a;
        private double _d;
        private double _tw;
        private double _bf;
        private double _tf;
        private double _k_des;
        private double _k_det;
        private double _gage;
        private double _wt__ft;
        private double _bf__2_tf;
        private double _d_tw;
        private double _ix;
        private double _sx;
        private double _rx;
        private double _y_bar;
        private double _zx;
        private double _yp;
        private double _iy;
        private double _sy;
        private double _ry;
        private double _zy;
        private double _qs;
        private double _j;
        private double _cw;
        private double _ro_bar;
        private double _h;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double A
        {
            get
            {
                return _a;
            }
            set
            {
                _a = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double d
        {
            get
            {
                return _d;
            }
            set
            {
                _d = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double tw
        {
            get
            {
                return _tw;
            }
            set
            {
                _tw = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double bf
        {
            get
            {
                return _bf;
            }
            set
            {
                _bf = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double tf
        {
            get
            {
                return _tf;
            }
            set
            {
                _tf = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double k_des
        {
            get
            {
                return _k_des;
            }
            set
            {
                _k_des = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double k_det
        {
            get
            {
                return _k_det;
            }
            set
            {
                _k_det = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double gage
        {
            get
            {
                return _gage;
            }
            set
            {
                _gage = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double wt__ft
        {
            get
            {
                return _wt__ft;
            }
            set
            {
                _wt__ft = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double bf__2_tf
        {
            get
            {
                return _bf__2_tf;
            }
            set
            {
                _bf__2_tf = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double d_tw
        {
            get
            {
                return _d_tw;
            }
            set
            {
                _d_tw = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Ix
        {
            get
            {
                return _ix;
            }
            set
            {
                _ix = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Sx
        {
            get
            {
                return _sx;
            }
            set
            {
                _sx = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double rx
        {
            get
            {
                return _rx;
            }
            set
            {
                _rx = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double y_bar
        {
            get
            {
                return _y_bar;
            }
            set
            {
                _y_bar = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Zx
        {
            get
            {
                return _zx;
            }
            set
            {
                _zx = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double yp
        {
            get
            {
                return _yp;
            }
            set
            {
                _yp = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Iy
        {
            get
            {
                return _iy;
            }
            set
            {
                _iy = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Sy
        {
            get
            {
                return _sy;
            }
            set
            {
                _sy = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double ry
        {
            get
            {
                return _ry;
            }
            set
            {
                _ry = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Zy
        {
            get
            {
                return _zy;
            }
            set
            {
                _zy = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Qs
        {
            get
            {
                return _qs;
            }
            set
            {
                _qs = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double J
        {
            get
            {
                return _j;
            }
            set
            {
                _j = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Cw
        {
            get
            {
                return _cw;
            }
            set
            {
                _cw = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double ro_bar
        {
            get
            {
                return _ro_bar;
            }
            set
            {
                _ro_bar = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double H{
            get
            {
                return _h;
            }
            set
            {
                _h = value;
            }
        }
    }
}