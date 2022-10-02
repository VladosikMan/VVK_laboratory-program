using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using СonstructorVVK.data;

namespace СonstructorVVK.entity
{
    class QuestionChoiceOne : Question, INotifyPropertyChanged
    {
        //значение будет список всех вариантов
        //ответ правильный вариант из списка
        private List<string> mValue;
        private string mAnswer;

        public List<string> Value
        {
            get { return mValue; }
            set
            {
                mValue = value;
                OnPropertyChanged();
            }
        }
        public string Answer
        {
            get { return mAnswer; }
            set
            {
                mAnswer = value;
                OnPropertyChanged();
            }
        }
    }
}
