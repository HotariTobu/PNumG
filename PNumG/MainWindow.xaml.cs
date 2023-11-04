using System.Windows;

namespace PNumG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel ViewModel;
        private IOManager IOManager;

        public MainWindow()
        {
            InitializeComponent();
            ViewModel = (MainWindowViewModel)DataContext;
            IOManager = new IOManager();
        }

        private async void Sieve()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
