
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
        private MainViewModel mainViewModel;
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //загрузка вьюмодел для кнопок меню
            MainWindowViewModel vm = new MainWindowViewModel();
            //даем доступ к этому кодбихайнд
            vm.CodeBehind = this;
            //делаем эту вьюмодел контекстом данных
            this.DataContext = vm;
            //загрузка стартовой View
            LoadView(ViewType.Main);
        }
        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.Main:
                    //загружаем вьюшку, ее вьюмодель
                    MainView view = new MainView();
                    MainViewModel vm = new MainViewModel(this);
                    //связываем их м/собой
                    view.DataContext = vm;
                    //отображаем
                    this.OutputView.Content = view;
                    break;
                case ViewType.Settings:
                    SettingsView viewF = new SettingsView();
                    SettingsViewModel vmF = new SettingsViewModel(this);
                    viewF.DataContext = vmF;
                    this.OutputView.Content = viewF;
                    break;
            }

        }
    }
}
