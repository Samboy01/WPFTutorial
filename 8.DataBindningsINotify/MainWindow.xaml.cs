using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace _8.DataBindningsINotify
{
    
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            // Sätter datakontexten till detta objekt (MainWindow)
            // så att UI kan binda till properties i denna klass
            //
            DataContext = this;
            InitializeComponent();
        }

        private string boundText;

        // Event som triggas när en property ändras
        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundText; }
            set 
            { 
                boundText = value;// Uppdaterar värdet

                // Skickar notifiering till UI att BoundText har ändrats
                OnPropertyChanged();
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));

            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "Sets from code";
        }

        private void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}