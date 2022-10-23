using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Questions.Variants
{
    public class VariantInterval : Variant, IVariant<double, List<double>>
    {
        public VariantInterval(VariantsType type ,  List<double> value)
        {
            Type = type;
            Value = value;
        }
        public  List<double> Value { get; set; }

        public  double GenerateVar()
        {
            Random random = new Random();
            return random.NextDouble() * (Value[1] - Value[0]) + Value[0];
        }
        public override double getGenerate()
        {
            return GenerateVar();
        }
    }
}
