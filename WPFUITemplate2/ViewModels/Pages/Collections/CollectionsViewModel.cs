// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WPFUITemplate2.ControlsLookup;
using WPFUITemplate2.Models;
using WPFUITemplate2.Views.Pages.Collections;

namespace WPFUITemplate2.ViewModels.Pages.Collections
{
    public partial class CollectionsViewModel : ObservableObject
    {
        [ObservableProperty]
        private ICollection<NavigationCard> _navigationCards = new ObservableCollection<NavigationCard>(
            ControlPages
                .FromNamespace(typeof(CollectionsPage).Namespace!)
                .Select(
                    x =>
                        new NavigationCard()
                        {
                            Name = x.Name,
                            Icon = x.Icon,
                            Description = x.Description,
                            PageType = x.PageType
                        }
                )
        );
    }

}

