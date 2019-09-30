using Prism.Commands;
using System.Windows.Input;

namespace MainModuleLibrary
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
