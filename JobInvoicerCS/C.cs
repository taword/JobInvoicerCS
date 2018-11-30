using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace JobInvoicerCS
{

    /// <remarks/>
    [Serializable()]
    public partial class C : Material, INotifyPropertyChanged
    {
        // Properties
        private string dField;

        private string twField;

        private string bfField;

        private string tfField;

        private string k_desField;

        private string k_detField;

        private string tField;

        private string gageField;

        private string rtsField;

        private string hoField;

        private string eoField;

        private string ixField;

        private string sxField;

        private string rxField;

        private string zxField;

        private string iyField;

        private string syField;

        private string ryField;

        private string x_barField;

        private string zyField;

        private string xpField;

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
        public string tw
        {
            get
            {
                return this.twField;
            }
            set
            {
                this.twField = value;
                this.RaisePropertyChanged("tw");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string bf
        {
            get
            {
                return this.bfField;
            }
            set
            {
                this.bfField = value;
                this.RaisePropertyChanged("bf");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string tf
        {
            get
            {
                return this.tfField;
            }
            set
            {
                this.tfField = value;
                this.RaisePropertyChanged("tf");
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
        public string T
        {
            get
            {
                return this.tField;
            }
            set
            {
                this.tField = value;
                this.RaisePropertyChanged("T");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string gage
        {
            get
            {
                return this.gageField;
            }
            set
            {
                this.gageField = value;
                this.RaisePropertyChanged("gage");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string rts
        {
            get
            {
                return this.rtsField;
            }
            set
            {
                this.rtsField = value;
                this.RaisePropertyChanged("rts");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string ho
        {
            get
            {
                return this.hoField;
            }
            set
            {
                this.hoField = value;
                this.RaisePropertyChanged("ho");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string eo
        {
            get
            {
                return this.eoField;
            }
            set
            {
                this.eoField = value;
                this.RaisePropertyChanged("eo");
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
            return base.ToString() + string.Format
                (
                "C: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23}, {24}, {25}, {26}, {27}",
                this.A, this.bf, this.Cw, this.d, this.eo, this.gage, this.H, this.ho, this.Ix, this.Iy,
                this.J, this.k_des, this.k_det, this.ro_bar, this.rts, this.rx, this.ry, this.Size, this.Sx, this.Sy,
                this.T, this.tf, this.tw, this.wt__ft, this.x_bar, this.xp, this.Zx, this.Zy
                );
        }
    }
}
