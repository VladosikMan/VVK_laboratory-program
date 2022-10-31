using ModelsLibrary.Questions.Variants;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Questions.Scope
{
    public class Var
    {

        public Var(string name, double value)
        {
            variants = new List<Variant>();
            variants.Add(new VariantConstant(VariantsType.Constant, value));
            Name = name;
        }
      
        public string Name { get; set; }
        private double Value { get; set; }

        public List<Variant> variants { get; set; }

        public double GenerateVariant(int num)
        {
            Value = variants[num].getGenerate();
            return Value;
        }
        //у переменной есть список вариантов гененирования 
        public void AddVariant(Variant variant)
        {
            variants.Add(variant);
        }
        public void DeleteVariant(int num)
        {
            variants.RemoveAt(num);
        }
        public double GetValue()
        {
            return Value;
        }
    }

}
