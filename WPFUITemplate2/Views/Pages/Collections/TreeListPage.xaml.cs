// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using Wpf.Ui.Common;
using Wpf.Ui.Controls;
using WPFUITemplate2.ControlsLookup;
using WPFUITemplate2.ViewModels.Pages.Collections;

namespace WPFUITemplate2.Views.Pages.Collections
{
    [GalleryPage("Collapsable list.", SymbolRegular.TextBulletListTree24)]
    public partial class TreeListPage : INavigableView<TreeListViewModel>
    {
        public TreeListViewModel ViewModel { get; }

        public TreeListPage(TreeListViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }

}

