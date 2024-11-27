using _23.UsingViewModels.ViewModel;
using System.Windows;

namespace _23.UsingViewModels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel vm = new MainWindowViewModel();
            // Sätter DataContext för fönstret till den skapade ViewModel-instansen
            DataContext = vm;
        }
    }
}