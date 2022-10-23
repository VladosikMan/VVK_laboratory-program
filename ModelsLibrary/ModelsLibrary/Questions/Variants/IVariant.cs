using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Questions.Variants
{
    public interface IVariant<T, V> 
    {
        // данные для генерации, список, интервал, константа
        public V Value { get; set; }
        //функция генерации переменной
        public T GenerateVar();
    }
}
