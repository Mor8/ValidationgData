using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationgData
{
    class Person : INotifyPropertyChanged
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

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
