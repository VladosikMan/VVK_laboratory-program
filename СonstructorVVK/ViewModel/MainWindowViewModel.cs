using System;
using System.Collections.Generic;
using System.Text;
using СonstructorVVK.View;


namespace СonstructorVVK.ViewModel
{
    class MainWindowViewModel : CreateQuestionWindowViewModel
    {

    
        public IMainWindowsCodeBehind CodeBehind { get; set; }


        private RelayCommand _LoadCreateQuestionUCCommand;
        public RelayCommand LoadCreateQuestionUCCommand
        {
            get
            {
                return _LoadCreateQuestionUCCommand = _LoadCreateQuestionUCCommand ??
                  new RelayCommand(OnLoadCreateQuestionUC, CanLoadCreateQuestionUC);
            }
        }
        private bool CanLoadCreateQuestionUC()
        {
            return true;
        }
        private void OnLoadCreateQuestionUC()
        {
            CodeBehind.LoadView(ViewType.CreateQuestion);
        }



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

        public MainWindowViewModel(IDialogService dialogService) : base(dialogService)
        {
        }

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
