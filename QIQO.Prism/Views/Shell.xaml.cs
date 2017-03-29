using QIQO.Prism.ViewModels;
using System.Windows;

namespace QIQO.Prism.Views
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : Window
    {
        public Shell(ShellViewModel view_model)
        {
            InitializeComponent();
            DataContext = view_model;
        }
    }
}
