using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using СonstructorVVK.data;

namespace СonstructorVVK.entity
{
    class QuestionText: Question, INotifyPropertyChanged
    {
        //ответом являеться список синонимов ответа
        //дополнительно - учитывать ли регистр
        private List<String> mAnswer;
        private bool mRegister;

        public List<String> Answer
        {
            get { return mAnswer; }
            set
            {
                mAnswer = value;
                OnPropertyChanged();
            }
        }
        public bool Register
        {
            get { return mRegister; }
            set
            {
                mRegister = value;
                OnPropertyChanged();
            }
        }
    }
}
