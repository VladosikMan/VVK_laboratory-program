using System;
using System.Collections.Generic;
using System.Text;
using СonstructorVVK.View;

namespace СonstructorVVK
{
    public interface IMainWindowsCodeBehind
    {
        /// <summary>
        /// Загрузка нужной View
        /// </summary>
        /// <param name="view">экземпляр UserControl</param>
        void LoadView(ViewType typeView);
    }

}
