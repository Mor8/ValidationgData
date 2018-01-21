using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationgData
{
    class Person : INotifyPropertyChanged, IDataErrorInfo
    {
        protected virtual void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        string _name;
        public string Name
        {
            get { return _name;}
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string columnName]
        {
            get
            {
                switch(columnName)
                {
                    case nameof(Name):
                        if (string.IsNullOrWhiteSpace(Name))
                            return "Name cannot be empty";
                        break;
                    case nameof(Age):
                        if (Age < 1)
                            return "Age must be a positive integer";
                        break;
                }
                return null;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
