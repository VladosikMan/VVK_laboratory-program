
using ModelsLibrary;
using ModelsLibrary.Questions;
using System.Collections.Generic;
using System.Windows;
using СonstructorVVK.ViewModel;
using System.Collections.Specialized;
using ModelsLibrary.Questions.Scope;
using ModelsLibrary.Questions.Variants;
using СonstructorVVK.View;
using СonstructorVVK.ViewModel;

namespace СonstructorVVK
{
   public partial class MainWindow : Window, IMainWindowsCodeBehind
    {
        private MainWindowViewModel mainVM;
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;

           

        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            mainVM = new MainWindowViewModel();
            mainVM.CodeBehind = this;
            this.DataContext = mainVM;
            LoadView(ViewType.Main);
        }
        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.Main:
                    MainView view = new MainView();
                    this.OutputView.Content = view;
                    break;
                case ViewType.Settings:
                    SettingsView viewF = new SettingsView();
                    this.OutputView.Content = viewF;
                    break;
            }

        }
    }
}
