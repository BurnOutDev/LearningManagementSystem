using System;

namespace LearningManagementSystem.GUI.UWP.Core
{
    public interface INavigationMenuItem
    {
        Type DestinationPage { get; }
        object Arguments { get; }
        string Label { get; }
    }
}