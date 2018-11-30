using System.ComponentModel;
using System.Xml.Serialization;
using System.Xml.Schema;

namespace JobInvoicerCS
{
    public class Material : INotifyPropertyChanged
    {
        private string _sizeField;

        private string _aField;

        private string _wtFtField;

        protected readonly Fractions Fractions = new Fractions();

        // Properties
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
                RaisePropertyChanged("Size");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string A
        {
            get
            {
                return _aField;
            }
            set
            {
                _aField = value;
                RaisePropertyChanged("A");
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string WtFt
        {
            get
            {
                return _wtFtField;
            }
            set
            {
                _wtFtField = value;
                RaisePropertyChanged("wt__ft");
            }
        }

        public override string ToString()
        {
            return $"Material: {A}, {Size}, {WtFt}; ";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            var propertyChanged = PropertyChanged;
            propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
