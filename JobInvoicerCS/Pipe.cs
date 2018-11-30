using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Xml.Schema;

namespace JobInvoicerCS
{
    /// <remarks/>
    [Serializable]
    public class Pipe : Material, INotifyPropertyChanged
    {
        private string odField;

        private string idField;

        private string t_nomField;

        private string t_desField;

        private string d_tField;

        private string iField;

        private string sField;

        private string rField;

        private string zField;

        private string jField;

        private string cField;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string OD
        {
            get
            {
                return this.odField;
            }
            set
            {
                this.odField = value;
                this.RaisePropertyChanged("OD");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("ID");
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
        public string D_t
        {
            get
            {
                return this.d_tField;
            }
            set
            {
                this.d_tField = value;
                this.RaisePropertyChanged("D_t");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string I
        {
            get
            {
                return this.iField;
            }
            set
            {
                this.iField = value;
                this.RaisePropertyChanged("I");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string S
        {
            get
            {
                return this.sField;
            }
            set
            {
                this.sField = value;
                this.RaisePropertyChanged("S");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
                this.RaisePropertyChanged("r");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
                this.RaisePropertyChanged("Z");
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
                "Pipe: {0}, {1}, {2},{3},{4},{5},{6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}",
                this.A, this.C, this.D_t, this.I, this.ID, this.J, this.OD, this.r,
                this.S, this.Size, this.t_des, this.t_nom, this.wt__ft, this.Z
                );
        }
    }
}
