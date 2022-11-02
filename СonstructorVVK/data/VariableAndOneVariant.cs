using ModelsLibrary.Questions.Scope;
using ModelsLibrary.Questions.Variants;
using System;
using System.Collections.Generic;
using System.Text;

namespace СonstructorVVK.data
{
    class VariableAndOneVariant
    {
        public string Name { get; set; }
        private double Value { get; set; }

        public  Variant variant{ get; set; }

        public VariableAndOneVariant(string name)
        {
            
            Name = name;
        }
        public VariableAndOneVariant(Var  var)
        {
            Name = var.Name;
        }

    }
}
