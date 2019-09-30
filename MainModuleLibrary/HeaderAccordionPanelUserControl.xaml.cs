using System.Windows.Controls;

namespace MainModuleLibrary
{
    /// <summary>
    /// Interaction logic for HeaderAccordionPanelUserControl.xaml
    /// </summary>
    public partial class HeaderAccordionPanelUserControl : UserControl
    {
        public HeaderAccordionPanelUserControl()
        {
            InitializeComponent();
            this.DataContext = new HeaderAccordionPanelViewModel();
        }
    }
}
