// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using Wpf.Ui.Common;
using Wpf.Ui.Controls;
using WPFUITemplate2.ControlsLookup;
using WPFUITemplate2.ViewModels.Pages.DateAndTime;

namespace WPFUITemplate2.Views.Pages.DateAndTime
{
    [GalleryPage("Presents a calendar to the user.", SymbolRegular.CalendarLtr24)]
    public partial class CalendarPage : INavigableView<CalendarViewModel>
    {
        public CalendarViewModel ViewModel { get; }

        public CalendarPage(CalendarViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }

}

