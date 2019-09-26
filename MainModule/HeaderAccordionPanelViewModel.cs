using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfQuickStart.MainModule
{
    class HeaderAccordionPanelViewModel
    {
        public HeaderAccordionPanelViewModel()
        {
            this.CloseHeaderAccordionPanelCommand = new DelegateCommand<object>(this.OnClosePanel, this.CanClosePanel);
        }

        public ICommand CloseHeaderAccordionPanelCommand { get; private set; }

        private void OnClosePanel(object arg)
        {
        }

        private bool CanClosePanel(object arg)
        {
            return true;
        }
    }
}
