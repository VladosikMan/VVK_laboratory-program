using ModelsLibrary.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelsLibrary
{
    public class Subject
    {
        public string Title { get; set; }

        public List<Question> Questions { get; set; }

        public Subject(string title)
        {
            Title = title;
        }

        public void AddQuestionRange(List<Question> questions)
        {
            Questions.AddRange(questions);
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public Question GetQuestion()
        {
            return Questions.Last();
        }
    }
}
