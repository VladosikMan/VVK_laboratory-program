using System;

namespace ModelsLibrary.Questions
{
    public interface IQuestion<T> where T : Question
    {
        public QuestionType Type { get; set; }

        public string Text { get; set; }

        public double Rate { get; set; }
     
        public byte[] PictureBytes { get; set; }

        /* Например
         * [Non Serialize]
         * public Image 
         * {
         *      get => PictureBytes.ToImage();
         *      set => PictureBytes = value.ToBytes();
         * }
         */

        public string SerializeClientVersion();

        public double GetRate(T question);

        public void SetPicture(byte[] picture);
    }
}
