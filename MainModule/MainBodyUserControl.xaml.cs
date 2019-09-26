using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfQuickStart.MainModule
{
    /// <summary>
    /// Interaction logic for MainBodyUserControl.xaml
    /// </summary>
    public partial class MainBodyUserControl : UserControl
    {
        public MainBodyUserControl()
        {
            InitializeComponent();
            this.DataContext = new MainBodyViewModel();
        }
    }
}
