using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace AngularAndWebApi.Models
{
    public class Item : INotifyPropertyChanged
    {
        private string _name;
        private string _type;

        public int Id { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}