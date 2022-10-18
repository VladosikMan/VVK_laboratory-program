using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Questions
{
    [Serializable]
    public class FloatQuestion : TextQuestion
    {
        public int Radix { get; set; }

        public FloatQuestion(string text, string answer, int radix, double rate) 
            : base(text, answer, rate)
        {
            Type = QuestionType.FloatQuestion;
            Radix = radix;
        }

        public override string SerializeClientVersion()
        {
            var clientVersion = new FloatQuestion(Text, string.Empty, Radix, Rate);

            return SerializeFabric<FloatQuestion>.Serialize(clientVersion);
        }

        public double GetRate(FloatQuestion question)
        {
            // Делаешь какую угодно логику 

            return Convert.ToSingle(Answer) == Math.Round(Convert.ToSingle(question), Radix)
                ? Rate
                : 0;
        }
    }
}
