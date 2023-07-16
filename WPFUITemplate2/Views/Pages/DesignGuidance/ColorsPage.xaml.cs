﻿// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using Wpf.Ui.Controls;
using WPFUITemplate2.ViewModels.Pages.DesignGuidance;

namespace WPFUITemplate2.Views.Pages.DesignGuidance
{
    /// <summary>
    /// Interaction logic for ColorsPage.xaml
    /// </summary>
    public partial class ColorsPage : INavigableView<ColorsViewModel>
    {
        public ColorsViewModel ViewModel { get; }

        public ColorsPage(ColorsViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }

}

