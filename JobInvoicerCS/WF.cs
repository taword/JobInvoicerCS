using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Xml.Schema;

namespace JobInvoicerCS
{
    /// <remarks/>
    [Serializable]
    public class WF : Material, INotifyPropertyChanged
    {
        private string dField;

        private string twField;

        private string bfField;

        private string tfField;

        private string k_desField;

        private string k_detField;

        private string k1Field;

        private string tField;

        private string gageField;

        private string bf__2_tfField;

        private string h_twField;

        private string ixField;

        private string sxField;

        private string rxField;

        private string zxField;

        private string iyField;

        private string syField;

        private string ryField;

        private string zyField;

        private string rtsField;

        private string hoField;

        private string jField;

        private string cwField;

        private string wnoField;

        private string sw1Field;

        private string qfField;

        private string qwField;

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
        public string k1
        {
            get
            {
                return this.k1Field;
            }
            set
            {
                this.k1Field = value;
                this.RaisePropertyChanged("k1");
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
        public string bf__2_tf
        {
            get
            {
                return this.bf__2_tfField;
            }
            set
            {
                this.bf__2_tfField = value;
                this.RaisePropertyChanged("bf__2_tf");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string h_tw
        {
            get
            {
                return this.h_twField;
            }
            set
            {
                this.h_twField = value;
                this.RaisePropertyChanged("h_tw");
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
        public string Wno
        {
            get
            {
                return this.wnoField;
            }
            set
            {
                this.wnoField = value;
                this.RaisePropertyChanged("Wno");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Sw1
        {
            get
            {
                return this.sw1Field;
            }
            set
            {
                this.sw1Field = value;
                this.RaisePropertyChanged("Sw1");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Qf
        {
            get
            {
                return this.qfField;
            }
            set
            {
                this.qfField = value;
                this.RaisePropertyChanged("Qf");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Qw
        {
            get
            {
                return this.qwField;
            }
            set
            {
                this.qwField = value;
                this.RaisePropertyChanged("Qw");
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
                "DoubleAngle: {0}, {1}, {2},{3},{4},{5},{6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23}, {24}, {25}, {26}, {27}, {28}, {29}",
                this.A, this.bf, this.bf__2_tf, this.Cw, this.d, this.gage, this.h_tw, this.ho, this.Ix, this.Iy,
                this.J, this.k_des, this.k_det, this.k1, this.Qf, this.Qw, this.rts, this.rx, this.ry, this.Size,
                this.Sw1, this.Sx, this.Sy, this.T, this.tf, this.tw, this.Wno, this.wt__ft, this.Zx, this.Zy
                );
        }
    }
}