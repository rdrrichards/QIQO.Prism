using ModuleA.ViewModels;
using System.Windows.Controls;

namespace ModuleA.Views
{
    /// <summary>
    /// Interaction logic for ModuleAListView.xaml
    /// </summary>
    public partial class ModuleAListView : UserControl
    {
        public ModuleAListView(ModuleAListViewModel view_model)
        {
            InitializeComponent();
            DataContext = view_model;
        }
    }
}
