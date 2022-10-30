using ModelsLibrary;
using ModelsLibrary.Questions;
using ModelsLibrary.Questions.Scope;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using СonstructorVVK.recources;
using СonstructorVVK.View;

namespace СonstructorVVK.ViewModel
{
   public  class MainViewModel : INotifyPropertyChanged
    {
     
        public ObservableCollection<Lab> Labs { get; set; }


        private Lab selectedItem;

        public Lab SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }

        private Subject selectedSub;

        public Subject SelectedSub
        {
            get { return selectedSub; }
            set
            {
                selectedSub = value;
                OnPropertyChanged();
            }
        }

        private Question selectedQue;

        public Question SelectedQue
        {
            get { return selectedQue; }
            set
            {
                selectedQue = value;
                OnPropertyChanged();
            }
              
        }

        public MainViewModel()
        {
            Labs = new ObservableCollection<Lab>();
            var lab = new Lab("Первая лаба", 80);

            var questions = new ObservableCollection<Question>()
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

            questions = new ObservableCollection<Question>()
            {
                task,
                task2
            };
            lab.AddSubject("Задачи от Жака Фреско", questions);
            lab.AddSharedScope(scope);
            Labs.Add(lab);
            // loadAllLab();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


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



        //  Обработка команд

        private RelayCommand<Lab> removeLab;
        public RelayCommand<Lab> RemoveLab
        {
            get
            {
                return removeLab ??
                  (removeLab = new RelayCommand<Lab>(lab =>
                  {
           
                      if (lab != null)
                      {
                          Labs.Remove(lab);
                      }
                  },
                 (lab) => Labs.Count > 0));
            }
        }
        private void RemoveFunc(Lab lab)
        {
            Labs.Remove(lab);
        }

        // команда добавления новой лабораторной
        private RelayCommand<Lab> addLab;
        public RelayCommand<Lab> AddLab
        {
            get
            {
                return addLab ??
                  (addLab = new RelayCommand<Lab>(obj =>
                  {
                      Lab newLab = new Lab("SFDFsd", 23);
                      Labs.Add(newLab);
                  }));
            }
        }

        private RelayCommand<Lab> addSubject;
        public RelayCommand<Lab> AddSubject
        {
            get
            {
                return addSubject ??
                  (addSubject = new RelayCommand<Lab>(lab =>
                  {

                      lab.AddSubject("Titke", null);


                  }));
            }
        }

        private RelayCommand<Subject> removeSubject;
        public RelayCommand<Subject> RemoveSubject
        {
            get
            {
                return removeSubject ??
                  (removeSubject = new RelayCommand<Subject>(subject =>
                  {
                      if (subject != null)
                      {
                          SelectedItem.Subjects.Remove(subject);
                      }
                  },
                 (subject) => Labs.Count > 0));
            }
        }


        private RelayCommand<Subject> addQuestion;
        public RelayCommand<Subject> AddQuestion
        {
            get
            {
                return addQuestion ??
                  (addQuestion = new RelayCommand<Subject>(subject =>
                  {
                      if (subject != null)
                      {
                          TextQuestion question = new TextQuestion("Вопросики", "De", 11);
                          subject.Questions.Add(question);
                      }
                  },
                 (question) => Labs.Count > 0));
            }
        }

        private RelayCommand<Question> removeQuestion;
        public RelayCommand<Question> RemoveQuestion
        {
            get
            {
                return removeQuestion ??
                  (removeQuestion = new RelayCommand<Question>(question =>
                  {
                      if (question != null)
                      {
                          SelectedSub.Questions.Remove(question);
                      }
                  },
                 (question) => Labs.Count > 0));
            }
        }


        private RelayCommand _LoadMainUCCommand;
        public RelayCommand LoadMainUCCommand
        {
            get
            {
                return _LoadMainUCCommand = _LoadMainUCCommand ??
                  new RelayCommand(OnLoadMainUC, CanLoadMainUC);
            }
        }
        private bool CanLoadMainUC()
        {
            return true;
        }
        private void OnLoadMainUC()
        {
            _MainCodeBehind.LoadView(ViewType.Settings);
        }

    }
}
