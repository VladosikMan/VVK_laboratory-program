﻿using System;
using System.Collections.Generic;
using System.Text;
using СonstructorVVK.View;

namespace СonstructorVVK.ViewModel
{
    class CreateQuestionWindowViewModel
    {
        public string DisplayedImagePath
        {
            get { return @"C:\Users\1\git\VVK_laboratory-program\СonstructorVVK\recources\images\logo.png"; }
        }

        public ICreateQuestionWindowsCodeBehind CodeBehind { get; set; }

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
