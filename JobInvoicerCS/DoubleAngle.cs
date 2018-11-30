using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Xml.Schema;

namespace JobInvoicerCS
{
    /// <remarks />
    [Serializable()]
    public partial class DoubleAngle : Material, INotifyPropertyChanged
    {
        // Properties
        private string dField;

        private string bField;

        private string tField;

        private string ixField;

        private string sxField;

        private string rxField;

        private string y_barField;

        private string zxField;

        private string ypField;

        private string iyField;

        private string syField;

        private string ryField;

        private string zyField;

        private string ro_barField;

        private string hField;

        private string qsField;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string d
        {
            get
            {
                return this.dField;
            }
            set
            {
                this.dField = value;
                this.RaisePropertyChanged("d");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string b
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
                this.RaisePropertyChanged("b");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string t
        {
            get
            {
                return this.tField;
            }
            set
            {
                this.tField = value;
                this.RaisePropertyChanged("t");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Ix
        {
            get
            {
                return this.ixField;
            }
            set
            {
                this.ixField = value;
                this.RaisePropertyChanged("Ix");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Sx
        {
            get
            {
                return this.sxField;
            }
            set
            {
                this.sxField = value;
                this.RaisePropertyChanged("Sx");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string rx
        {
            get
            {
                return this.rxField;
            }
            set
            {
                this.rxField = value;
                this.RaisePropertyChanged("rx");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string y_bar
        {
            get
            {
                return this.y_barField;
            }
            set
            {
                this.y_barField = value;
                this.RaisePropertyChanged("y_bar");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Zx
        {
            get
            {
                return this.zxField;
            }
            set
            {
                this.zxField = value;
                this.RaisePropertyChanged("Zx");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string yp
        {
            get
            {
                return this.ypField;
            }
            set
            {
                this.ypField = value;
                this.RaisePropertyChanged("yp");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Iy
        {
            get
            {
                return this.iyField;
            }
            set
            {
                this.iyField = value;
                this.RaisePropertyChanged("Iy");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Sy
        {
            get
            {
                return this.syField;
            }
            set
            {
                this.syField = value;
                this.RaisePropertyChanged("Sy");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string ry
        {
            get
            {
                return this.ryField;
            }
            set
            {
                this.ryField = value;
                this.RaisePropertyChanged("ry");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Zy
        {
            get
            {
                return this.zyField;
            }
            set
            {
                this.zyField = value;
                this.RaisePropertyChanged("Zy");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string ro_bar
        {
            get
            {
                return this.ro_barField;
            }
            set
            {
                this.ro_barField = value;
                this.RaisePropertyChanged("ro_bar");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string H
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
                this.RaisePropertyChanged("H");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Qs
        {
            get
            {
                return this.qsField;
            }
            set
            {
                this.qsField = value;
                this.RaisePropertyChanged("Qs");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format
                (
                "DoubleAngle: {0}, {1}, {2},{3},{4},{5},{6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}",
                this.A, this.b, this.d, this.H, this.Ix, this.Iy, this.Qs, this.ro_bar, this.rx, this.ry,
                this.Size, this.Sx, this.Sy, this.t, this.wt__ft, this.y_bar, this.yp, this.Zx, this.Zy);
        }
    }
}