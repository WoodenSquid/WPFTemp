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
#if DEBUG
[GalleryPage("List inside the TreeView.", SymbolRegular.TextBulletListTree24)]
#endif
    public partial class TreeViewPage : INavigableView<TreeViewViewModel>
    {
        public TreeViewViewModel ViewModel { get; }

        public TreeViewPage(TreeViewViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }

}

