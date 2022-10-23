using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelsLibrary.Questions.Variants
{
    public enum  VariantsType
    {
        Unknown,
        [Display(Name = "Генерация по умолчанию")]
        Default,
        [Display(Name = "Генерация константы")]
        Constant,
        [Display(Name = "Генерация случайного числа в промежутке")]
        RandomInterval,
        [Display(Name = "Генерация случайного числа их списка вариантов")]
        RandomListVariant,
    }
}
