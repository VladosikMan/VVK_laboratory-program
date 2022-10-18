using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Questions
{
    [Serializable]
    public class TextQuestion : Question
    {
        public string Answer { get; set; }

        public TextQuestion(string text, string answer, double rate) 
            : base(text, rate)
        {
            Type = QuestionType.TextQuestion;
            Answer = answer;
        }

        public override string SerializeClientVersion()
        {
            var clientVersion = new TextQuestion(Text, string.Empty, Rate);

            return SerializeFabric<TextQuestion>.Serialize(clientVersion);
        }

        public double GetRate(TextQuestion question)
        {
            return Answer == question.Answer 
                ? Rate 
                : 0;
        }
    }
}
