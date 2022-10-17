using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using СonstructorVVK.recources;

namespace СonstructorVVK.ViewModel
{
    class MainViewModel
    {
        //сохранение json лабы в папку
        public void saveLab(Lab lab)
        {
            try {
                File.WriteAllText(StringRecources.PATH_TO_SAVE_FILE + lab.Name +".json", lab.Serialize());
            } catch {
                
            }
        }
        //получить список сохранённых лаб
        public List<Lab> loadAllLab()
        {
            List<Lab> labs = new List<Lab>();
            string[] filePaths = Directory.GetFiles(StringRecources.PATH_TO_SAVE_FILE, "*.json");
            foreach(string x in filePaths)
                labs.Add(new Lab(File.ReadAllText(x)));
            return labs;
        }
    }
    
}
