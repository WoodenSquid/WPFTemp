using System;
using Wpf.Ui.Common;

namespace WPFUITemplate2.ControlsLookup
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class GalleryPageAttribute : Attribute
    {
        public string Description { get; }
        public SymbolRegular Icon { get; }

        public GalleryPageAttribute(string description, SymbolRegular icon)
        {
            Description = description;
            Icon = icon;
        }
    }

}

