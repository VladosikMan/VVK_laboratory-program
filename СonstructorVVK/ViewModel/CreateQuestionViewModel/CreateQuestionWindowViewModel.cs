using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WpfApplication1;
using СonstructorVVK.View;
using Microsoft.Win32;
using System.Windows;
using System.ComponentModel;
using System.Windows.Markup;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

namespace СonstructorVVK.ViewModel 
{
    class CreateQuestionWindowViewModel : NotificationObject
    {
        IDialogService dialogService;
        public CreateQuestionWindowViewModel(IDialogService dialogService)
        {
            this.dialogService = dialogService;
            ChoiseDynamicVMs = new ObservableCollection<ChoiseDynamicViewModel>();
            ChoiseDynamicOneVMs = new ObservableCollection<ChoiseDynamicOneViewModel>();
            SequenceDynamicVMs = new ObservableCollection<SequenceDynamicViewModel>();
        }
        
        #region SequenceDynamicVMs

        private ObservableCollection<SequenceDynamicViewModel> _SequenceDynamicVMs;

        public ObservableCollection<SequenceDynamicViewModel> SequenceDynamicVMs
        {
            get { return _SequenceDynamicVMs; }
            set { SetProperty(ref _SequenceDynamicVMs, value, () => SequenceDynamicVMs); }
        }

        #endregion
        #region RemoveSequenceDynamic

        private RelayCommand _RemoveSequenceDynamicUCCommand;

        public RelayCommand RemoveSequenceDynamicUCCommand
        {
            get
            {
                return _RemoveSequenceDynamicUCCommand = _RemoveSequenceDynamicUCCommand ??
                  new RelayCommand(OnRemoveSequenceDynamicUC, CanRemoveSequenceDynamicUC);
            }
        }
        private bool CanRemoveSequenceDynamicUC()
        {
            return true;
        }
        private void OnRemoveSequenceDynamicUC()
        {
            try
            {
                SequenceDynamicVMs.RemoveAt(SequenceDynamicVMs.Count - 1);
            }
            catch
            {

            }

        }


        #endregion
        #region LoadSequenceDynamic

        private RelayCommand _LoadSequenceDynamicUCCommand;

        public RelayCommand LoadSequenceDynamicUCCommand
        {
            get
            {
                return _LoadSequenceDynamicUCCommand = _LoadSequenceDynamicUCCommand ??
                  new RelayCommand(OnLoadSequenceDynamicUC, CanLoadSequenceDynamicUC);
            }
        }
        private bool CanLoadSequenceDynamicUC()
        {
            return true;
        }
        private void OnLoadSequenceDynamicUC()
        {
            SequenceDynamicVMs.Add(new SequenceDynamicViewModel());
        }


        #endregion
        #region ChoiseDynamicOneVMs

        private ObservableCollection<ChoiseDynamicOneViewModel> _ChoiseDynamicOneVMs;

        public ObservableCollection<ChoiseDynamicOneViewModel> ChoiseDynamicOneVMs
        {
            get { return _ChoiseDynamicOneVMs; }
            set { SetProperty(ref _ChoiseDynamicOneVMs, value, () => ChoiseDynamicOneVMs); }
        }

        #endregion
        #region RemoveChoiseDynamicOne

        private RelayCommand _RemoveChoiseDynamicOneUCCommand;

        public RelayCommand RemoveChoiseDynamicOneUCCommand
        {
            get
            {
                return _RemoveChoiseDynamicOneUCCommand = _RemoveChoiseDynamicOneUCCommand ??
                  new RelayCommand(OnRemoveChoiseDynamicOneUC, CanRemoveChoiseDynamicOneUC);
            }
        }
        private bool CanRemoveChoiseDynamicOneUC()
        {
            return true;
        }
        private void OnRemoveChoiseDynamicOneUC()
        {
            try
            {
                ChoiseDynamicOneVMs.RemoveAt(ChoiseDynamicOneVMs.Count - 1);
            }
            catch
            {

            }

        }


        #endregion
        #region LoadChoiseDynamicOne

        private RelayCommand _LoadChoiseDynamicOneUCCommand;

        public RelayCommand LoadChoiseDynamicOneUCCommand
        {
            get
            {
                return _LoadChoiseDynamicOneUCCommand = _LoadChoiseDynamicOneUCCommand ??
                  new RelayCommand(OnLoadChoiseDynamicOneUC, CanLoadChoiseDynamicOneUC);
            }
        }
        private bool CanLoadChoiseDynamicOneUC()
        {
            return true;
        }
        private void OnLoadChoiseDynamicOneUC()
        {
            ChoiseDynamicOneVMs.Add(new ChoiseDynamicOneViewModel());
        }


        #endregion
        #region ChoiseDynamicVMs

        private ObservableCollection<ChoiseDynamicViewModel> _ChoiseDynamicVMs;

        public ObservableCollection<ChoiseDynamicViewModel> ChoiseDynamicVMs
        {
            get { return _ChoiseDynamicVMs; }
            set { SetProperty(ref _ChoiseDynamicVMs, value, () => ChoiseDynamicVMs); }
        }

        #endregion
        #region RemoveChoiseDynamic

        private RelayCommand _RemoveChoiseDynamicUCCommand;

        public RelayCommand RemoveChoiseDynamicUCCommand
        {
            get
            {
                return _RemoveChoiseDynamicUCCommand = _RemoveChoiseDynamicUCCommand ??
                  new RelayCommand(OnRemoveChoiseDynamicUC, CanRemoveChoiseDynamicUC);
            }
        }
        private bool CanRemoveChoiseDynamicUC()
        {
            return true;
        }
        private void OnRemoveChoiseDynamicUC()
        {
            try
            {
                ChoiseDynamicVMs.RemoveAt(ChoiseDynamicVMs.Count - 1);
            }
            catch
            {
           
            }
 
        }


        #endregion
        #region LoadChoiseDynamic

        private RelayCommand _LoadChoiseDynamicUCCommand;

        public RelayCommand LoadChoiseDynamicUCCommand
        {
            get
            {
                return _LoadChoiseDynamicUCCommand = _LoadChoiseDynamicUCCommand ??
                  new RelayCommand(OnLoadChoiseDynamicUC, CanLoadChoiseDynamicUC);
            }
        }
        private bool CanLoadChoiseDynamicUC()
        {
            return true;
        }
        private void OnLoadChoiseDynamicUC()
        {
            ChoiseDynamicVMs.Add(new ChoiseDynamicViewModel());
        }


        #endregion

        public string displayedImagePath = "/recources/images/logo.png";

        public string DisplayedImagePath
        {
            get 
            {
                return displayedImagePath;
            }
            set
            {
                displayedImagePath = value;
                OnPropertyChanged();
            }
        }

        private RelayCommand _LoadImageUCCommand;
        public RelayCommand LoadImageUCCommand
        {
            get
            {
                return _LoadImageUCCommand = _LoadImageUCCommand ??
                  new RelayCommand(OnLoadImageUC, CanLoadImageUC);
            }

        }
        private bool CanLoadImageUC()
        {
            return true;
        }
        private void OnLoadImageUC()
        {
             if (dialogService.OpenFileDialog() == true)
              {
                  MessageBox.Show(displayedImagePath);
                  displayedImagePath = dialogService.FilePath;
                  MessageBox.Show(displayedImagePath);
                 

              }
    
        }

        public ICreateQuestionWindowsCodeBehind CodeBehind { get; set; }

        private RelayCommand _LoadSequenceQuestionUCCommand;
        public RelayCommand LoadSequenceQuestionUCCommand
        {
            get
            {
                return _LoadSequenceQuestionUCCommand = _LoadSequenceQuestionUCCommand ??
                  new RelayCommand(OnLoadSequenceQuestionUC, CanLoadSequenceQuestionUC);
            }
        }
        private bool CanLoadSequenceQuestionUC()
        {
            return true;
        }
        private void OnLoadSequenceQuestionUC()
        {
            CodeBehind.LoadView(ViewType.SequenceQuestion);
        }

        private RelayCommand _LoadTextQuestionUCCommand;
        public RelayCommand LoadTextQuestionUCCommand
        {
            get
            {
                return _LoadTextQuestionUCCommand = _LoadTextQuestionUCCommand ??
                  new RelayCommand(OnLoadTextQuestionUC, CanLoadTextQuestionUC);
            }
        }
        private bool CanLoadTextQuestionUC()
        {
            return true;
        }
        private void OnLoadTextQuestionUC()
        {
            CodeBehind.LoadView(ViewType.TextQuestion);
        }

        private RelayCommand _LoadChoiseOneQuestionUCCommand;
        public RelayCommand LoadChoiseOneQuestionUCCommand
        {
            get
            {
                return _LoadChoiseOneQuestionUCCommand = _LoadChoiseOneQuestionUCCommand ??
                  new RelayCommand(OnLoadChoiseOneQuestionUC, CanLoadChoiseOneQuestionUC);
            }
        }
        private bool CanLoadChoiseOneQuestionUC()
        {
            return true;
        }
        private void OnLoadChoiseOneQuestionUC()
        {
            CodeBehind.LoadView(ViewType.ChoiseOneQuestion);
        }

        private RelayCommand _LoadChoiseQuestionUCCommand;
        public RelayCommand LoadChoiseQuestionUCCommand
        {
            get
            {
                return _LoadChoiseQuestionUCCommand = _LoadChoiseQuestionUCCommand ??
                  new RelayCommand(OnLoadChoiseQuestionUC, CanLoadChoiseQuestionUC);
            }
        }
        private bool CanLoadChoiseQuestionUC()
        {
            return true;
        }
        private void OnLoadChoiseQuestionUC()
        {
            CodeBehind.LoadView(ViewType.ChoiseQuestion);
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
