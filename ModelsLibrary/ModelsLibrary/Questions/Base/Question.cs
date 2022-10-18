
using ModelsLibrary.Questions.Scope;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Questions
{
    public abstract class Question : IQuestion<Question>, ISharedScoped
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

        /// <summary>
        /// Текст.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Картинка в байтах.
        /// </summary>
        public byte[] PictureBytes { get; set; }

        /// <summary>
        /// "Вес" вопроса.
        /// </summary>
        public double Rate { get; set; }

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
    }
}
