using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text;
using СonstructorVVK.recources;

namespace СonstructorVVK.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        //Fields
        private IMainWindowsCodeBehind _MainCodeBehind;

        //ctor
        public MainViewModel(IMainWindowsCodeBehind codeBehind)
        {
            if (codeBehind == null) throw new ArgumentNullException(nameof(codeBehind));

            _MainCodeBehind = codeBehind;
        }
        //привязанные данные
        public ObservableCollection<Lab> labs = new ObservableCollection<Lab>();



        //сохранение json лабы в папку
        public void saveLab(Lab lab)
        {
            try
            {
                File.WriteAllText(StringRecources.PATH_TO_SAVE_FILE + lab.Name + ".json", lab.Serialize());
            }
            catch
            {

            }
        }
        //получить список сохранённых лаб
        public void loadAllLab()
        {
            string[] filePaths = Directory.GetFiles(StringRecources.PATH_TO_SAVE_FILE, "*.json");
            foreach (string x in filePaths)
                labs.Add(new Lab(File.ReadAllText(x)));
        }
        public void createLab()
        {
            var lab = new Lab("TextNameLab" + labs.Count, 80, labs.Count);
            labs.Add(lab);
        }
    }
}
