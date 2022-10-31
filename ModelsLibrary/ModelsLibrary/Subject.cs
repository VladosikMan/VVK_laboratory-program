using ModelsLibrary.Questions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ModelsLibrary
{
    public class Subject : INotifyPropertyChanged
    {
        public string Title { get; set; }

        private double percent;
        public double Percent
        {
            get
            {
                return percent;
            }
            set
            {
                percent = value;
                OnPropertyChanged();
            }
        }

        private int successPercent { get; set; }
        public int SuccessPercent
        {
            get
            {
                return successPercent;
            }
            set
            {
                successPercent = value;
                OnPropertyChanged();
            }
        }

        // выдавать вопросы случайным образом или нет
        private bool randomOut { get; set; }
        public bool RandomOut
        {
            get
            {
                return randomOut;
            }
            set
            {
                randomOut = value;
                OnPropertyChanged();
            }
        }
        // количество выдамаемых вопросов в тесте
        private int numQue { get; set; }
        public int NumQue
        {
            get
            {
                return numQue;
            }
            set
            {
                numQue = value;
                OnPropertyChanged();
            }
        }


        public ObservableCollection<Question> Questions { get; set; }

        public Subject(string title)
        {
            Title = title;
            Percent = 100;
            SuccessPercent = 80;
            RandomOut = true;
            
        }
        public Subject(string title, double percent, int successPercent, bool randomOut)
        {
            Title = title;
            Percent = percent;
            SuccessPercent = successPercent;
            RandomOut = randomOut;
        }

        
        public void AddQuestionRange(List<Question> questions)
        {
           // Questions.AD
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public Question GetQuestion()
        {
            return Questions.Last();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
