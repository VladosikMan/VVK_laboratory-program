using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace СonstructorVVK.data
{
    //класс родитель 
    public class Question: INotifyPropertyChanged
    {
        //описание общих свойств вопросов
        private string mTextQuestion;
        private TypeQuestion mTypeQuestion;
        //getters/setters
        public string TextQuestion
        {
            get { return mTextQuestion; }
            set {
                mTextQuestion = value;
                OnPropertyChanged();
            }
        }
        public TypeQuestion TypeQuestion
        {
            get { return mTypeQuestion; }
            set
            {
                mTypeQuestion = value;
                OnPropertyChanged();
            }
        }


        // слушатели изменений
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
