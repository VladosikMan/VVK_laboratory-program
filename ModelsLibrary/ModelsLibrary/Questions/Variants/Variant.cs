using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Questions.Variants
{
    public abstract class Variant
    {
        public VariantsType Type { get; set; }

        public abstract double getGenerate();

    }
}
 