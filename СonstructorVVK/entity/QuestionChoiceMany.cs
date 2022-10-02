using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using СonstructorVVK.data;

namespace СonstructorVVK.entity
{
    class QuestionChoiceMany : Question, INotifyPropertyChanged
    {
        //значение будет список всех вариантов
        //ответ список правильных вариантов
        private List<string> mValue;
        private List<string> mAnswer;
        public List<string> Value
        {
            get { return mValue; }
            set
            {
                mValue = value;
                OnPropertyChanged();
            }
        }
        public List<string> Answer
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
