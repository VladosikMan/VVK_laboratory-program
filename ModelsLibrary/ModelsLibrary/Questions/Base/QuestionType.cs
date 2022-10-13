using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelsLibrary.Questions
{
    public enum QuestionType
    {
        Unknown,
        [Display(Name = "Вопрос с текстовым ответом")] // Можно получить через Type.GetDisplayName()
        TextQuestion,
        [Display(Name = "Вопрос с числовым ответом")]  // Не имеет смысла, можно использовать TextQuestion
        IntQuestion,
        [Display(Name = "Вопрос с дробным ответом")]
        FloatQuestion,
        [Display(Name = "Вопрос с вариантом(-ами) ответов")]
        ChoiceQuestion,
        [Display(Name = "Вопрос с сортировкой ответ")]
        SequenceQuestion,
        [Display(Name = "Задача")]
        TaskQuestion
    }
}
