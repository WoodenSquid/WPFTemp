// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using Wpf.Ui.Common;
using Wpf.Ui.Controls;
using WPFUITemplate2.ControlsLookup;
using WPFUITemplate2.ViewModels.Pages.Navigation;

namespace WPFUITemplate2.Views.Pages.Navigation
{
    [GalleryPage(
    "Shows the trail of navigation taken to the current location.",
    SymbolRegular.Navigation24
)]
    public partial class BreadcrumbBarPage : INavigableView<BreadcrumbBarViewModel>
    {
        public BreadcrumbBarViewModel ViewModel { get; }

        public BreadcrumbBarPage(BreadcrumbBarViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }

}

