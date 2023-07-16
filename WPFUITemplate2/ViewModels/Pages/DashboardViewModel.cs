﻿// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using Wpf.Ui.Contracts;
using WPFUITemplate2.Helpers;

namespace WPFUITemplate2.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        private readonly INavigationService _navigationService;

        public DashboardViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        [RelayCommand]
        private void OnCardClick(string parameter)
        {
            if (String.IsNullOrWhiteSpace(parameter))
                return;

            var pageType = NameToPageTypeConverter.Convert(parameter);

            if (pageType == null)
                return;

            _navigationService.Navigate(pageType);
        }
    }

}

