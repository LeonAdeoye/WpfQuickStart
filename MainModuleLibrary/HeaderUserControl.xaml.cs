using System.Windows.Controls;

namespace MainModuleLibrary
{
    /// <summary>
    /// Interaction logic for HeaderUserControl.xaml
    /// </summary>
    public partial class HeaderUserControl : UserControl
    {
        public HeaderUserControl()
        {
            InitializeComponent();
            this.DataContext = new HeaderViewModel();
        }
    }
}
