using ModelsLibrary;
using ModelsLibrary.Questions;
using ModelsLibrary.Questions.Scope;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text;
using СonstructorVVK.recources;
using СonstructorVVK.View;

namespace СonstructorVVK.ViewModel
{
   public  class MainViewModel : INotifyPropertyChanged
    {
     
        public ObservableCollection<Lab> Labs { get; set; }


        private Lab selectedLab;
        public Lab SelectedLab
        {
            get { return selectedLab; }
            set
            {
                selectedLab = value;
              
            }
        }
        public MainViewModel()
        {
            Labs = new ObservableCollection<Lab>();
            loadAllLab();

            /*Labs = new ObservableCollection<Lab>();

            var lab = new Lab("Третья лаба", 80);
            lab.Id = 3;
            var questions = new List<Question>()
            {
                new TextQuestion("Сколько стоит слон?", "10 рублей", 5),
                new ChoiceQuestion("Кто живет в Африке?", new List<string>()
                {
                    "Слон",
                    "Мартышка",
                    "Белый медведь"
                }, new List<string>()
                {
                    "Слон",
                    "Мартышка"
                }, 15)
            };
            lab.AddSubject("Тест", questions);

            var scope = new SharedScope();
            scope.AddVariable("A", 5);
            scope.AddVariable("B", 3);
            scope.AddVariable("C", 0);
            scope.AddVariable("D", 0);

            var task = new TaskQuestion("Задача, посчитайте c = a * b, при a = 5, b = 3", 20, "c = a * b");
            task.SetSharedScope(scope);

            var task2 = new TaskQuestion("Задача, посчитайте d = c + 5", 20, "d = c + 5");
            task2.SetSharedScope(scope);

            questions = new List<Question>()
            {
                task,
                task2
            };
            lab.AddSubject("Задачи от Жака Фреско", questions);
            lab.AddSharedScope(scope);

            saveLab(lab);
*/


        }


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
        private void loadAllLab()
        {
            string[] filePaths = Directory.GetFiles(StringRecources.PATH_TO_SAVE_FILE, "*.json");
            foreach (string x in filePaths)
                Labs.Add(new Lab(File.ReadAllText(x)));
        }
        public void createLab()
        {
            var lab = new Lab("TextNameLab" + Labs.Count, 80, Labs.Count);
            Labs.Add(lab);
        }
    }
}
