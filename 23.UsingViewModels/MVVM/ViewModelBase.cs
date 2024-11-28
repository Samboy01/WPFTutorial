using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _23.UsingViewModels.MVVM
{
    //INotify tillåter oss att kunna ändra på egenskaper till objekt dynamsikt i vår GUI
    //Medan ObservableCollection tillåter oss att ändra själva objekten i en lista dynamiskt i vår GUI
    internal class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
