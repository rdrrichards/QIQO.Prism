using System.Collections.ObjectModel;

namespace ModuleA.ViewModels
{
    public class ModuleAListViewModel
    {
        public ModuleAListViewModel()
        {
            ListItems = new ObservableCollection<string> { "Item1", "Item1" };
        }
        public ObservableCollection<string> ListItems { get; }
    }
}
