using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using СonstructorVVK.data;

namespace СonstructorVVK.entity
{
    class QuestionCompar : Question, INotifyPropertyChanged
    {
        //сопоставление - имеем два списка, должны быть исходны
        private List<string> mAnswerOne;
        private List<string> mAnswerTwo;
        public List<string> AnswerOne
        {
            get { return mAnswerOne; }
            set
            {
                mAnswerOne = value;
                OnPropertyChanged();
            }
        }
        public List<string> AnswerTwo
        {
            get { return mAnswerTwo; }
            set
            {
                mAnswerTwo = value;
                OnPropertyChanged();
            }
        }
    }
}
