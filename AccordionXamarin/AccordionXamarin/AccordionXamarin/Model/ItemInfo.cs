using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AccordionXamarin
{
    public class ItemInfo : INotifyPropertyChanged
    {
        private string _name;
        private string _description;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string Property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Property));
        }
    }
}
