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
    public class Angles : object
    {
        private AnglesAngle[] _items;

        /// <remarks/>
        [XmlElement("Angle", Form = XmlSchemaForm.Unqualified)]
        public AnglesAngle[] Items
        {
            get { return _items; }
            set { _items = value; }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DebuggerStepThrough()]
    [XmlType(AnonymousType = true)]
    public class AnglesAngle : object
    {
        private string _size;

        private double _a;

        private double _d;

        private double _b;

        private double _t;

        private double _kDes;

        private double _kDet;

        private double _wtFt;

        private double _ix;

        private double _sx;

        private double _rx;

        private double _yBar;

        private double _zx;

        private double _yp;

        private double _iy;

        private double _sy;

        private double _ry;

        private double _xBar;

        private double _zy;

        private double _xp;

        private double _iz;

        private double _sz;

        private double _rz;

        private double _tAnA;

        private double _qs;

        private double _j;

        private double _cw;

        private double _roBar;

        private double _h;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double A
        {
            get { return _a; }
            set { _a = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double D
        {
            get { return _d; }
            set { _d = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double B
        {
            get { return _b; }
            set { _b = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double T
        {
            get { return _t; }
            set { _t = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double KDes
        {
            get { return _kDes; }
            set { _kDes = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double KDet
        {
            get { return _kDet; }
            set { _kDet = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double WtFt
        {
            get { return _wtFt; }
            set { _wtFt = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Ix
        {
            get { return _ix; }
            set { _ix = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Sx
        {
            get { return _sx; }
            set { _sx = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Rx
        {
            get { return _rx; }
            set { _rx = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double YBar
        {
            get { return _yBar; }
            set { _yBar = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Zx
        {
            get { return _zx; }
            set { _zx = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Yp
        {
            get { return _yp; }
            set { _yp = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Iy
        {
            get { return _iy; }
            set { _iy = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Sy
        {
            get { return _sy; }
            set { _sy = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Ry
        {
            get { return _ry; }
            set { _ry = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double XBar
        {
            get { return _xBar; }
            set { _xBar = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Zy
        {
            get { return _zy; }
            set { _zy = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Xp
        {
            get { return _xp; }
            set { _xp = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Iz
        {
            get { return _iz; }
            set { _iz = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Sz
        {
            get { return _sz; }
            set { _sz = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Rz
        {
            get { return _rz; }
            set { _rz = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double TanA
        {
            get { return _tAnA; }
            set { _tAnA = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Qs
        {
            get { return _qs; }
            set { _qs = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double J
        {
            get { return _j; }
            set { _j = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Cw
        {
            get { return _cw; }
            set { _cw = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double RoBar
        {
            get { return _roBar; }
            set { _roBar = value; }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double H
        {
            get { return _h; }
            set { _h = value; }
        }
    }
}