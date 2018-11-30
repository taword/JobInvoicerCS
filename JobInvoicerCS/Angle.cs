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
    /// <remarks/>
    [Serializable()]
    public partial class Angle : Material, INotifyPropertyChanged
    {
        private string dField;

        private string bField;

        private string tField;

        private string k_desField;

        private string k_detField;

        private string ixField;

        private string sxField;

        private string rxField;

        private string y_barField;

        private string zxField;

        private string ypField;

        private string iyField;

        private string syField;

        private string ryField;

        private string x_barField;

        private string zyField;

        private string xpField;

        private string izField;

        private string szField;

        private string rzField;

        private string tAN_aField;

        private string qsField;

        private string jField;

        private string cwField;

        private string ro_barField;

        private string hField;

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
        public string k_des
        {
            get
            {
                return this.k_desField;
            }
            set
            {
                this.k_desField = value;
                this.RaisePropertyChanged("k_des");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string k_det
        {
            get
            {
                return this.k_detField;
            }
            set
            {
                this.k_detField = value;
                this.RaisePropertyChanged("k_det");
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
        public string x_bar
        {
            get
            {
                return this.x_barField;
            }
            set
            {
                this.x_barField = value;
                this.RaisePropertyChanged("x_bar");
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
        public string xp
        {
            get
            {
                return this.xpField;
            }
            set
            {
                this.xpField = value;
                this.RaisePropertyChanged("xp");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Iz
        {
            get
            {
                return this.izField;
            }
            set
            {
                this.izField = value;
                this.RaisePropertyChanged("Iz");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Sz
        {
            get
            {
                return this.szField;
            }
            set
            {
                this.szField = value;
                this.RaisePropertyChanged("Sz");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string rz
        {
            get
            {
                return this.rzField;
            }
            set
            {
                this.rzField = value;
                this.RaisePropertyChanged("rz");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string TAN_a
        {
            get
            {
                return this.tAN_aField;
            }
            set
            {
                this.tAN_aField = value;
                this.RaisePropertyChanged("TAN_a");
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

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string J
        {
            get
            {
                return this.jField;
            }
            set
            {
                this.jField = value;
                this.RaisePropertyChanged("J");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Cw
        {
            get
            {
                return this.cwField;
            }
            set
            {
                this.cwField = value;
                this.RaisePropertyChanged("Cw");
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
            return base.ToString() + string.Format(
                "Angle: {0}, {1}, {2},{3},{4},{5},{6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23}, {24}, {25}, {26}, {27}, {28}",
                this.A, this.b, this.Cw, this.d, this.H, this.Ix, this.Iy, this.Iz, this.J, this.k_des,
                this.k_det, this.Qs, this.ro_bar, this.rx, this.ry, this.rz, this.Size, this.Sx, this.Sy, this.Sz,
                this.t, this.TAN_a, this.wt__ft, this.x_bar, this.xp, this.y_bar, this.yp, this.Zx, this.Zy
                );
        }

    }
}
