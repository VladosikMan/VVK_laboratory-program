using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using СonstructorVVK.data;

namespace СonstructorVVK.entity
{
    public class QuestionNumInt : Question, INotifyPropertyChanged
    {
        private int mAnswer;

        public int Answer
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
