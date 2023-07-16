// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using Wpf.Ui.Common;
using Wpf.Ui.Controls;
using WPFUITemplate2.ControlsLookup;
using WPFUITemplate2.ViewModels.Pages.StatusAndInfo;

namespace WPFUITemplate2.Views.Pages.StatusAndInfo
{
    [GalleryPage("Inline message card.", SymbolRegular.ErrorCircle24)]
    public partial class InfoBarPage : INavigableView<InfoBarViewModel>
    {
        public InfoBarViewModel ViewModel { get; }

        public InfoBarPage(InfoBarViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }

}

