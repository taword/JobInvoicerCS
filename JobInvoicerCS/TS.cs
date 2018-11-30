using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Xml.Schema;

namespace JobInvoicerCS
{
    /// <remarks/>
    [Serializable]
    public class TS : Material, INotifyPropertyChanged
    {
        private string hField;

        private string bField;

        private string t_nomField;

        private string t_desField;

        private string b_tField;

        private string h_tField;

        private string ixField;

        private string sxField;

        private string rxField;

        private string zxField;

        private string iyField;

        private string syField;

        private string ryField;

        private string zyField;

        private string h_flatField;

        private string b_flatField;

        private string jField;

        private string cField;

        private string a_surfField;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
                this.RaisePropertyChanged("h");
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
        public string t_nom
        {
            get
            {
                return this.t_nomField;
            }
            set
            {
                this.t_nomField = value;
                this.RaisePropertyChanged("t_nom");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string t_des
        {
            get
            {
                return this.t_desField;
            }
            set
            {
                this.t_desField = value;
                this.RaisePropertyChanged("t_des");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string b_t
        {
            get
            {
                return this.b_tField;
            }
            set
            {
                this.b_tField = value;
                this.RaisePropertyChanged("b_t");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string h_t
        {
            get
            {
                return this.h_tField;
            }
            set
            {
                this.h_tField = value;
                this.RaisePropertyChanged("h_t");
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
        public string h_flat
        {
            get
            {
                return this.h_flatField;
            }
            set
            {
                this.h_flatField = value;
                this.RaisePropertyChanged("h_flat");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string b_flat
        {
            get
            {
                return this.b_flatField;
            }
            set
            {
                this.b_flatField = value;
                this.RaisePropertyChanged("b_flat");
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
        public string C
        {
            get
            {
                return this.cField;
            }
            set
            {
                this.cField = value;
                this.RaisePropertyChanged("C");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string A_surf
        {
            get
            {
                return this.a_surfField;
            }
            set
            {
                this.a_surfField = value;
                this.RaisePropertyChanged("A_surf");
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
                "TS: {0}, {1}, {2},{3},{4},{5},{6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}",
                this.A, this.A_surf, this.b, this.b_flat, this.b_t, this.C, this.h, this.h_flat, this.h_t, this.Ix, this.Iy, this.J,
                this.rx, this.ry, this.Size, this.Sx, this.Sy, this.t_des, this.t_nom, this.wt__ft, this.Zx, this.Zy
                );
        }
    }
}