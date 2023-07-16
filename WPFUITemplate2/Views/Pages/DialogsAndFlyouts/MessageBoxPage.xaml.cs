// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.


using Wpf.Ui.Common;
using Wpf.Ui.Controls;
using WPFUITemplate2.ControlsLookup;
using WPFUITemplate2.ViewModels.Pages.DialogsAndFlyouts;

namespace WPFUITemplate2.Views.Pages.DialogsAndFlyouts
{
    [GalleryPage("Message box.", SymbolRegular.CalendarInfo20)]
    public partial class MessageBoxPage : INavigableView<MessageBoxViewModel>
    {
        public MessageBoxViewModel ViewModel { get; }

        public MessageBoxPage(MessageBoxViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }

}

