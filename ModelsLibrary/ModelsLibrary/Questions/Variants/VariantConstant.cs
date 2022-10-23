using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Questions.Variants
{
    public class VariantConstant : Variant, IVariant<double, double>
    {
        public VariantConstant(VariantsType type, double value)
        {
            Type = type;
            Value = value;
        }
        public  double Value { get ; set ; }

        //default  это constant 
        public  double GenerateVar()
        {
            return Value;
        }

        public override double getGenerate()
        {
            return GenerateVar();
        }
    }
}
