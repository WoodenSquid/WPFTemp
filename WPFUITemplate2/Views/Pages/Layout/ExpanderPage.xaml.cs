using Wpf.Ui.Common;
using Wpf.Ui.Controls;
using WPFUITemplate2.ControlsLookup;
using WPFUITemplate2.ViewModels.Pages.Layout;

namespace WPFUITemplate2.Views.Pages.Layout
{
    [GalleryPage("Expander control.", SymbolRegular.Code24)]
    public partial class ExpanderPage : INavigableView<ExpanderViewModel>
    {
        public ExpanderPage(ExpanderViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
        }

        public ExpanderViewModel ViewModel { get; }
    }

}

