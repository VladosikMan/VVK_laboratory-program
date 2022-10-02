using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using СonstructorVVK.data;

namespace СonstructorVVK.entity
{
    class QuestionSequence : Question, INotifyPropertyChanged
    {
        //последвательность, храним список вариантов, при вопросе сортируем
        private List<string> mAnswer;
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
