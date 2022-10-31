using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Questions.Variants
{
    public class VariantList : Variant, IVariant<double, List<double>>
    {
        public VariantList(VariantsType type, List<double> value)
        {
            Type = type;
            Value = value;
        }
        public  List<double> Value { get; set; }

        public  double GenerateVar()
        {
            Random r = new Random();
            return Value[r.Next(0, Value.Count)];
        }
        public override double getGenerate()
        {
            return GenerateVar();
        }
    }
}
