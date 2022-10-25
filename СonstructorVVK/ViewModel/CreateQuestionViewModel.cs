using ModelsLibrary.Questions;
using ModelsLibrary.Questions.Scope;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace СonstructorVVK.ViewModel
{
    class CreateQuestionViewModel : INotifyPropertyChanged
    {
        public CreateQuestionViewModel()
        { 
        }
        //Fields
        private ICreateQuestionWindowsCodeBehind _CreateQuestionCodeBehind;

        //ctor
        public CreateQuestionViewModel(ICreateQuestionWindowsCodeBehind codeBehind)
        {
            if (codeBehind == null) throw new ArgumentNullException(nameof(codeBehind));

            _CreateQuestionCodeBehind = codeBehind;
        }
        //наш объект, с которым мы будем работать
        // public Question Question { get; set; }
        // и понадобиться список имеющихся переменных SharedScope, его можно для примера создать самому из конструктора
        // public SharedScope SharedScope { get; set; }
 
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
