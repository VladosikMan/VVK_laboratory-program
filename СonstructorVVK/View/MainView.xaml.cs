using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication1;
using СonstructorVVK.ViewModel;

namespace СonstructorVVK.View
{
    /// <summary>
    /// Логика взаимодействия для MainView.xaml
    /// </summary>

    public partial class MainView : UserControl, IMainWindowsCodeBehind
    {
       
        private MainViewModel mainViewModel;
        public MainView()
        {
            InitializeComponent();
            mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
            mainViewModel.CodeBehind = this;
            SharedScopeView sharedScopeView = new SharedScopeView();
            this.OutputSharedScopeView.Content = sharedScopeView;
        }

        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.SettingsLab:

                    SettingsLabView view = new SettingsLabView();
                    this.OutputSettingView.Content = view;
                    view.SetLab(mainViewModel.SelectedItem);
                    break;
                case ViewType.SettingsSubject:

                    SettingsSubjectView viewF = new SettingsSubjectView();
                    this.OutputSettingView.Content = viewF;
                    viewF.SetSubject(mainViewModel.SelectedSub);
                    break;
                case ViewType.SettingsQuestion:

                    SettingsQuestionView viewC = new SettingsQuestionView();
                    this.OutputSettingView.Content = viewC;
                    viewC.SetQuestion(mainViewModel.SelectedQue);
                    break;
            }
        }
    }
   
}
   
