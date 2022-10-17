using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using СonstructorVVK.recources;

namespace СonstructorVVK.ViewModel
{
    class MainViewModel
    {
        //привязанные данные
        public ObservableCollection<Lab> labs = new ObservableCollection<Lab>();

       

        //сохранение json лабы в папку
        public void saveLab(Lab lab)
        {
            try {
                File.WriteAllText(StringRecources.PATH_TO_SAVE_FILE + lab.Name +".json", lab.Serialize());
            } catch {
                
            }
        }
        //получить список сохранённых лаб
        public void loadAllLab()
        {
            string[] filePaths = Directory.GetFiles(StringRecources.PATH_TO_SAVE_FILE, "*.json");
            foreach(string x in filePaths)
                labs.Add(new Lab(File.ReadAllText(x)));
        }
        public void createLab()
        {
            var lab = new Lab("TextNameLab" +labs.Count,80,labs.Count);
            labs.Add(lab);
        }
    }

    
}
