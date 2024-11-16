using System.Windows;

namespace _19.OpeningWindowsShow.View
{
    
    public partial class ModalWindow : Window
    {
        public bool Success {  get; set; }
        public string Input { get; set; }

        public ModalWindow(Window parentWindow)
        {
            Owner = parentWindow;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Success = true;
            Input = txtInput.Text;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void txtInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtInput.Text))
            {
                btnOk.IsEnabled = true;
            }
            else
            {
                btnOk.IsEnabled = false;
            }
        }
    }
}
