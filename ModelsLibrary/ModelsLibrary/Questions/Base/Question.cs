
using ModelsLibrary.Extensions;
using ModelsLibrary.Questions.Scope;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ModelsLibrary.Questions
{
    public abstract class Question : IQuestion<Question>, ISharedScoped, INotifyPropertyChanged
    {
        protected SharedScope mSharedScope;
        public SharedScope SharedScope
        {
            get { return mSharedScope; }
           
        }
        /// <summary>
        /// Тип вопроса.
        /// </summary>
        public QuestionType Type { get; set; }

        private string typeName { get; set; }
        public string TypeName
        {
            get
            {
                return EnumExtensions.GetDisplayName(Type);
            }
            set
            {
                typeName = value ;
                OnPropertyChanged();
            }

        }
        /// <summary>
        /// Текст.
        /// </summary>
        private string text;
        public string Text {
            get
            {
                return text;
            }
            set
            {
                text = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Картинка в байтах.
        /// </summary>
        public byte[] PictureBytes { get; set; }

        /// <summary>
        /// "Вес" вопроса.
        /// </summary>
        private double rate;
        public double Rate {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Получение клиентской версии вопроса.
        /// Скорее всего придется делать Фабрику сборки по this.Type
        /// </summary>
        /// <returns> Версия без ответа. </returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual string SerializeClientVersion()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Проврека ответа.
        /// </summary>
        /// <param name="question"> Версия клиента. </param>
        /// <returns> Кол-во баллов за решение (0 если не правильно). </returns>
        public double GetRate(Question question)
        {
            return Text == question.Text ? Rate : 0;
        }

        public void SetPicture(byte[] picture)
        {
            PictureBytes = picture;
        }

        public void SetSharedScope(SharedScope sharedScope)
        {
            mSharedScope = sharedScope;
        }

        public Question(string text, double rate)
        {
            Text = text;
            Rate = rate;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
