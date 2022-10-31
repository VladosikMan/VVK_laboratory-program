using System;
using System.Collections.Generic;
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
using СonstructorVVK.ViewModel;

namespace СonstructorVVK.View
{
    /// <summary>
    /// Логика взаимодействия для CreateQuestionView.xaml
    /// </summary>
    public partial class CreateQuestionView : UserControl, ICreateQuestionWindowsCodeBehind
    {
        private CreateQuestionWindowViewModel createQuestionVM;
     
        //   private CreateQuestionViewModel createQuestionViewModel;
        public CreateQuestionView()
        {
            InitializeComponent();
            
            // this.DataContext += CreateQuestionWindow_Loaded;
           // createQuestionViewModel = new CreateQuestionViewModel();
            this.Loaded += CreateQuestionWindow_Loaded;
        }
        private void CreateQuestionWindow_Loaded(object sender, RoutedEventArgs e)
        {
            createQuestionVM = new CreateQuestionWindowViewModel();
            createQuestionVM.CodeBehind = this;
            this.DataContext = createQuestionVM;
            LoadView(ViewType.Settings);
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
                case ViewType.CreateQuestion:
                    CreateQuestionView viewC = new CreateQuestionView();
                    this.OutputView.Content = viewC;
                    break;
            }

        }
    }
}
