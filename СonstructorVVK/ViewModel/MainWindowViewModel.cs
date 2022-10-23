using System;
using System.Collections.Generic;
using System.Text;
using СonstructorVVK.View;

namespace СonstructorVVK.ViewModel
{
    class MainWindowViewModel
    {
        public IMainWindowsCodeBehind CodeBehind { get; set; }
        private RelayCommand _LoadSettingsUCCommand;
        public RelayCommand LoadSettingsUCCommand
        {
            get
            {
                return _LoadSettingsUCCommand = _LoadSettingsUCCommand ??
                  new RelayCommand(OnLoadFirstUC, CanLoadFirstUC);
            }
        }
        private bool CanLoadFirstUC()
        {
            return true;
        }
        private void OnLoadFirstUC()
        {
            CodeBehind.LoadView(ViewType.Settings);
        }
        /// Возвращение к главной вьюшке
        /// </summary>
        private RelayCommand _LoadMainUCCommand;
        public RelayCommand LoadMainUCCommand
        {
            get
            {
                return _LoadMainUCCommand = _LoadMainUCCommand ??
                  new RelayCommand(OnLoadMainUC, CanLoadMainUC);
            }
        }
        private bool CanLoadMainUC()
        {
            return true;
        }
        private void OnLoadMainUC()
        {
            CodeBehind.LoadView(ViewType.Main);
        }
    }
}
