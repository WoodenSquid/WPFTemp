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
    [GalleryPage("Control for numeric input.", SymbolRegular.NumberSymbol24)]
    public partial class NumberBoxPage : INavigableView<NumberBoxViewModel>
    {
        public NumberBoxViewModel ViewModel { get; }

        public NumberBoxPage(NumberBoxViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }

}

