// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using Wpf.Ui.Common;
using WPFUITemplate2.Models;
using WPFUITemplate2.Services;
using WPFUITemplate2.Views.Windows;

namespace WPFUITemplate2.ViewModels.Pages.Windows
{
    public partial class WindowsViewModel : ObservableObject
    {
        private readonly WindowsProviderService _windowsProviderService;

        [ObservableProperty]
        private IEnumerable<WindowCard> _windowCards = new WindowCard[]
        {
        new("Monaco", "Visual Studio Code in your WPF app.", SymbolRegular.CodeBlock24, "monaco"),
        new("Editor", "Text editor with tabbed background.", SymbolRegular.ScanText24, "editor")
        };

        public WindowsViewModel(WindowsProviderService windowsProviderService)
        {
            _windowsProviderService = windowsProviderService;
        }

        [RelayCommand]
        public void OnOpenWindow(string value)
        {
            if (String.IsNullOrEmpty(value))
                return;

            switch (value)
            {
                case "monaco":
                    _windowsProviderService.Show<MonacoWindow>();
                    break;

                case "editor":
                    _windowsProviderService.Show<EditorWindow>();
                    break;
            }
        }
    }

}

