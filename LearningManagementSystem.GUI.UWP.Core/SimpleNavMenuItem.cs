﻿using System;
using Windows.UI.Xaml.Controls;

namespace LearningManagementSystem.GUI.UWP.Core
{
    public sealed class SimpleNavMenuItem : INavigationMenuItem
    {
        public string Label { get; set; }
        public Symbol Symbol { get; set; }
        public char SymbolAsChar => (char)Symbol;
        public object Arguments { get; set; }
        public Type DestinationPage { get; set; }
    }
}