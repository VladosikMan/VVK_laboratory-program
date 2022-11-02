using System;
using System.Collections.Generic;
using System.Text;

namespace СonstructorVVK.View
{
    public interface IBindingObject<T>
    {
 
        public void SetObject(T obj);
    }
}
