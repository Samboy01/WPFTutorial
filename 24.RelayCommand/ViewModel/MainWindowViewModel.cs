using _23.UsingViewModels.Model;
using _23.UsingViewModels.MVVM;
using System.Collections.ObjectModel;

namespace _23.UsingViewModels.ViewModel
{
    //Det vi egentligen gör i viewmodel är att använda denna koden istället för code behind
    internal class MainWindowViewModel : ViewModelBase
    {
        //Deklarerar en obeservable collection istället för en vanlig lista, då den tillåter att automatiskt uppdatera i GUI
        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(), canExecute => SelectedItem != null);
        public RelayCommand SaveCommand => new RelayCommand(execute => Save(), canExecute => CanSave());
        public MainWindowViewModel() 
        {
            //Implemenerar listan
            Items = new ObservableCollection<Item>();
           
        }

        private Item selectedItem;
        public Item SelectedItem
        {
            get { return selectedItem; }
            set 
            { 
                selectedItem = value;
                OnPropertyChanged();
            }
        }

        private void AddItem()
        {
            Items.Add(new Item
            {
                Name = "New Item",
                SerialNumber = "XXXXX",
                Quantity = 0
            }
                );
        }
        private void DeleteItem()
        {
            Items.Remove(SelectedItem); 
        }

        private void Save()
        {
            //Save
        }

        private bool CanSave()
        {
            return true;
        }

    }
}
