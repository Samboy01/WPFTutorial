using System.Windows;
using _19.OpeningWindowsShow.View;

namespace _19.OpeningWindowsShow
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            //Skapa en instans av "NormalWindow"
            NormalWindow normalWindow = new NormalWindow();
            normalWindow.Show();
        }

        private void btnModal_Click(object sender, RoutedEventArgs e)
        {
            //Vi skriver "this" för att visa att detta fönster är parent till modalWindow
            ModalWindow modalWindow = new ModalWindow(this);
            Opacity = 0.4;
            modalWindow.ShowDialog();
            Opacity = 1;
            if(modalWindow.Success == true)
            {
                txtInput.Text = modalWindow.Input;
            }
        }
    }
}