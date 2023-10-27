using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Ex27WPFMVVM1
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        string _myLabelText;
        public string MyLabelText
        {
            get {return _myLabelText;}
            set 
            {
                _myLabelText = value;
                OnPropertyChanged("MyLabelText");
            }
        }
        string _myTextBoxText;
        public string MyTextBoxText
        {
            get { return _myTextBoxText; }
            set 
            {
                _myTextBoxText = value;
                OnPropertyChanged("MyTextBoxText");
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
