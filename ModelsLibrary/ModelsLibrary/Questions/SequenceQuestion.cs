using ModelsLibrary.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelsLibrary.Questions
{
    public class SequenceQuestion : ChoiceQuestion
    {
        public SequenceQuestion(string text, List<string> suggested, List<string> answers, double rate) 
            : base(text, suggested, answers, rate)
        {
            Type = QuestionType.SequenceQuestion;
        }

        public double GetRate(SequenceQuestion question)
        {
            var correctCount = 0;

            for (int i = 0; i < question.AnswerChoices.Count; i++)
            {
                if (question.AnswerChoices[i] == AnswerChoices[i])
                {
                    correctCount++;
                }
            }

            return Math.Round(Rate / correctCount, 1);
        }

        public override string SerializeClientVersion()
        {
            var clientVersion = new SequenceQuestion(Text, SuggestedChoices.Shuffle(), new List<string>() { }, Rate);

            return SerializeFabric<SequenceQuestion>.Serialize(clientVersion);
        }
    }
}
