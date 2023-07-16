// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using Wpf.Ui.Common;
using Wpf.Ui.Controls;
using WPFUITemplate2.ControlsLookup;
using WPFUITemplate2.ViewModels.Pages.BasicInput;

namespace WPFUITemplate2.Views.Pages.BasicInput
{
    [GalleryPage("Button with binary choice.", SymbolRegular.CheckmarkSquare24)]
    public partial class CheckBoxPage : INavigableView<CheckBoxViewModel>
    {
        public CheckBoxViewModel ViewModel { get; }

        public CheckBoxPage(CheckBoxViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }

}

