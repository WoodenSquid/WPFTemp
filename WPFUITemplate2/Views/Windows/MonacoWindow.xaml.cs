// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using WPFUITemplate2.ViewModels.Windows;

namespace WPFUITemplate2.Views.Windows
{
    /// <summary>
    /// Interaction logic for MonacoWindow.xaml
    /// </summary>
    public partial class MonacoWindow
    {
        public MonacoWindowViewModel ViewModel { get; init; }

        public MonacoWindow(MonacoWindowViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();

            ViewModel.SetWebView(WebView);
        }
    }

}

