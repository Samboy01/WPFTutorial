using System.Windows;
using System.Windows.Controls;

namespace _7.TextboxControls.View.UserControls
{

    public partial class ClearableTextbox : UserControl
    {
        public ClearableTextbox()
        {
            InitializeComponent();
        }

        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set 
            { 
                placeholder = value; 
                tbPlaceholder.Text = placeholder;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            //Gör att vi stannar i textboxen
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Om textboxen är tom så kan vi se placeholdern (Texten)
            //När vi skriver i textboxen försvinner placholdern (Texten)
            if(string.IsNullOrEmpty(txtInput.Text))
            {
                tbPlaceholder.Visibility = Visibility.Visible;
            }
            else
            {
                tbPlaceholder.Visibility = Visibility.Hidden;
            }
        }
    }
}
