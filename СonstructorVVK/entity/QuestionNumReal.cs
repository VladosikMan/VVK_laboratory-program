using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using СonstructorVVK.data;

namespace СonstructorVVK.entity
{
    class QuestionNumReal: Question, INotifyPropertyChanged
    {
        // для вопроса с ответ вещественное число можно указать
        // само число, указываемоу в формате преподователя
        // диапазон, с которым будетт выдаваться правильный ответ
        // максильмальное число после запятой
        private double mAnswer;
        private double mStartDiaposon;
        private double mFinishDiaposon;
        private int mDecimal;

        public double Answer
        {
            get{ return mAnswer; }
            set
            {
                mAnswer = value;
                OnPropertyChanged();
            }
        }
        public double StartDiaposon
        {
            get { return mStartDiaposon; }
            set
            {
                mStartDiaposon = value;
                OnPropertyChanged();
            }
        }
        public double FinishDiaposon
        {
            get { return mFinishDiaposon; }
            set
            {
                mFinishDiaposon = value;
                OnPropertyChanged();
            }
        }
        public int Decimal
        {
            get { return mDecimal; }
            set
            {
                mDecimal = value;
                OnPropertyChanged();
            }
        }
    }
}
