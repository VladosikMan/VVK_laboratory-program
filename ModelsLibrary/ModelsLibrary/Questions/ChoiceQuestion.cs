using ModelsLibrary.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelsLibrary.Questions
{
    public class ChoiceQuestion : Question
    {
        public List<string> SuggestedChoices { get; set; }

        public List<string> AnswerChoices { get; set; }

        public ChoiceQuestion(string text, List<string> suggested, List<string> answers, double rate) 
            : base(text, rate)
        {
            Type = QuestionType.ChoiceQuestion;
            SuggestedChoices = suggested;
            AnswerChoices = answers;
        }

        public override string SerializeClientVersion()
        {
            var clientVersion = new ChoiceQuestion(Text, SuggestedChoices.Shuffle(), new List<string>() { }, Rate);

            return SerializeFabric<ChoiceQuestion>.Serialize(clientVersion);
        }

        public double GetRate(ChoiceQuestion question)
        {
            var correctCount = 0;
            
            foreach (var answer in question.AnswerChoices)
            {
                if (AnswerChoices.Contains(answer))
                {
                    correctCount++;
                }
            }

            return Math.Round(Rate / correctCount, 1);
        }
    }
}
