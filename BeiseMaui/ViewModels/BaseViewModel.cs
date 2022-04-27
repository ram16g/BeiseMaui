using BeiseMaui.Models;
using BeiseMaui.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BeiseMaui.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {

        [ObservableProperty]
        bool isBusy = false;

        [ObservableProperty]
        string title = string.Empty; 
    }
}
