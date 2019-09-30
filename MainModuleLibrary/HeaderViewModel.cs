using Prism.Commands;
using System.Windows.Input;

namespace MainModuleLibrary
{
    class HeaderViewModel
    {
        public HeaderViewModel()
        {
            this.OpenHeaderAccordionPanelCommand = new DelegateCommand<object>(this.OnOpenPanel, this.CanOpenPanel);
        }

        public ICommand OpenHeaderAccordionPanelCommand { get; private set; }

        private void OnOpenPanel(object arg)
        {
        }

        private bool CanOpenPanel(object arg)
        {
            return true;
        }
    }
}
