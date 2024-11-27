using System.Windows.Input;

namespace _23.UsingViewModels.MVVM
{
    //ICommand används för att definiera kommandon som kan bindas till UI-element.
    internal class RelayCommand : ICommand
    {
        //Action är en metod som aktiveras när kommandot aktiveras (Knapptryck) 
        //Action tar in ett objekt som parameter men retunerar inget värde
        private Action<object> execute;
        //Som en Action men retunerar värdet av bool parametern
        //Om den retuneras true kan kommandot utföras, annars inte.
        private Func<object, bool> canExecute;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            //
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
}
