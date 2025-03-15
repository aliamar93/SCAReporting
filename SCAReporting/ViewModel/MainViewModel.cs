using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SCAReporting.ViewModel
{
    //initialize 
    public partial class MainViewModel : ObservableObject
    {
        IConnectivity connectivity;

        public MainViewModel(IConnectivity connectivity)
        {
            items = new ObservableCollection<string>();
            this.connectivity = connectivity;
        }


        [ObservableProperty]
        ObservableCollection<string> items;



        [ObservableProperty]
        string text;


        [ICommand]
        async Task Add()
        {

            if (string.IsNullOrWhiteSpace(Text))
                return;

            if (connectivity.NetworkAccess != NetworkAccess.Internet)
                await Shell.Current.DisplayAlert("Uh Oh!", "No internet", "OK");
            //return;
            items.Add(text);
            //add items
            Text = string.Empty;
        }

        [ICommand]
        void Delete(string value)
        {
            if (items.Contains(value))
            {
                items.Remove(value);
            }
        }

        [ICommand]
        async void Tap(string value)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={value}");
        }
        //public string Text
        //{
        //    get => text;
        //    set
        //    {
        //        text = value;
        //        OnPropertyChanged(nameof(Text));
        //    }
        //}
        //public event PropertyChangedEventHandler? PropertyChanged;
        //void OnPropertyChanged(string name) =>
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
}
