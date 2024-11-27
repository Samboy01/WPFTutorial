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
        public MainWindowViewModel() 
        {
            //Implemenerar listan
            Items = new ObservableCollection<Item>();
            Items.Add(new Item 
            {
                Name = "Product1", 
                SerialNumber = "0001",
                Quantity = 5
            
            });
            Items.Add(new Item
            {
                Name = "Product2",
                SerialNumber = "0002",
                Quantity = 6

            });
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

        
    }
}
