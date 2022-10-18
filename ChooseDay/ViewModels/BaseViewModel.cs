﻿namespace ChooseDay.ViewModels
{
    /// <summary>
    /// Common view model for the app pages
    /// </summary>
    public partial class BaseViewModel : ObservableObject
    {
        // Using the ObservableObject available from the CommunityToolkit.Mvvm,
        // INotifyPropertyChanged implementation is already automatically generated.
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        [ObservableProperty]
        string title;

        public BaseViewModel()
        {

        }

        public bool IsNotBusy => !IsBusy;

    }
}
