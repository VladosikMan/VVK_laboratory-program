using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace СonstructorVVK.ViewModel
{
    class SettingsLabViewModel : INotifyPropertyChanged
    {
        private Lab selectedLab;

        public Lab SelectedLab
        {
            get { return selectedLab; }
            set
            {
                selectedLab = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
}
