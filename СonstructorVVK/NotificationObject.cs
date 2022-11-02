using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using ModelsLibrary;
using System.Collections.Generic;

namespace WpfApplication1
{
    public class NotificationObject : INotifyPropertyChanged
    {
    
        protected bool SetProperty<T>(ref T storage, T value, Expression<Func<T>> action)
        {
            if (Equals(storage, value))
                return false;
            storage = value;
            RaisePropertyChanged(action);
            return true;
        }

        protected void RaisePropertyChanged<T>(Expression<Func<T>> action)
        {
            var propertyName = GetPropertyName(action);
            RaisePropertyChanged(propertyName);
        }

        private static string GetPropertyName<T>(Expression<Func<T>> action)
        {
            var expression = (MemberExpression)action.Body;
            var propertyName = expression.Member.Name;
            return propertyName;
        }

        private void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

       public event PropertyChangedEventHandler PropertyChanged;
    

       public void OnPropertyChanged([CallerMemberName] string prop = "")
       {
           if (PropertyChanged != null)
               PropertyChanged(this, new PropertyChangedEventArgs(prop));
       }
    }
}
