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
    public class TubeSteelRounds : object
    {

        private TubeSteelRoundsTubeSteelRound[] _itemsField;

        /// <remarks/>
        [XmlElement("TubeSteelRound", Form = XmlSchemaForm.Unqualified)]
        public TubeSteelRoundsTubeSteelRound[] Items
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
    public class TubeSteelRoundsTubeSteelRound : object
    {

        private string _sizeField;

        private double _aField;

        private double _odField;

        private double _idField;

        private double _tNomField;

        private double _tDesField;

        private double _wtFtField;

        private double _dTField;

        private double _iField;

        private double _sField;

        private double _rField;

        private double _zField;

        private double _jField;

        private double _cField;

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
        public double Od
        {
            get
            {
                return _odField;
            }
            set
            {
                _odField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double TNom
        {
            get
            {
                return _tNomField;
            }
            set
            {
                _tNomField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double TDes
        {
            get
            {
                return _tDesField;
            }
            set
            {
                _tDesField = value;

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
        public double DT
        {
            get
            {
                return _dTField;
            }
            set
            {
                _dTField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double I
        {
            get
            {
                return _iField;
            }
            set
            {
                _iField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double S
        {
            get
            {
                return _sField;
            }
            set
            {
                _sField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double R
        {
            get
            {
                return _rField;
            }
            set
            {
                _rField = value;

            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Z
        {
            get
            {
                return _zField;
            }
            set
            {
                _zField = value;

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
        public double C
        {
            get
            {
                return _cField;
            }
            set
            {
                _cField = value;

            }
        }
    }
}