
using System.Windows.Controls;

using СonstructorVVK.ViewModel;

namespace СonstructorVVK.View
{
    /// <summary>
    /// Логика взаимодействия для MainView.xaml
    /// </summary>

    public partial class MainView : UserControl, IMainWindowsCodeBehind
    {
       
        private MainViewModel mainViewModel = new MainViewModel();
        public MainView()
        {
            InitializeComponent();
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
   
