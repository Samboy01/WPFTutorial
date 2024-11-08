using Microsoft.Win32;
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

namespace _10.OpenFileDigalogs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            //Anger vilka filer som ska visas
            fileDialog.InitialDirectory = @"C:\Users\samai\source\repos\WPFTutorial";
            //fileDialog.Filter = "C# Soruce Files | *.cs";
            fileDialog.Title = "Please pick a file";

            //Succes lagrar resultatet av valt fil eller ej
            bool ? success = fileDialog.ShowDialog();
            if(success == true)
            {
                //Visar filträdet
                string path = fileDialog.FileName;
                //Visar bara filen
                string fileName = fileDialog.SafeFileName;

                tbInfo.Text = path;
            }
            else
            {

            }
        }
    }
}