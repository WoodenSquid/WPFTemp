// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.


using Wpf.Ui.Common;
using Wpf.Ui.Controls;
using WPFUITemplate2.ControlsLookup;
using WPFUITemplate2.ViewModels.Pages.Text;

namespace WPFUITemplate2.Views.Pages.Text
{
    [GalleryPage("Plain text field.", SymbolRegular.TextColor24)]
    public partial class TextBoxPage : INavigableView<TextBoxViewModel>
    {
        public TextBoxViewModel ViewModel { get; }

        public TextBoxPage(TextBoxViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }

}

