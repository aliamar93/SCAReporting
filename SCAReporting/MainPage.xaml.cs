using SCAReporting.ViewModel;

namespace SCAReporting
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();

            //initialize 
            BindingContext = vm;
        }

        

        //private async void OnCounterClicked(object sender, EventArgs e)
        //{


        //    //await Shell.Current.GoToAsync("Reporting");
        //    //count++;

        //    //if (count == 1)
        //    //    CounterBtn.Text = $"Clicked {count} time";
        //    //else
        //    //    CounterBtn.Text = $"Clicked {count} times";



        //    //Mention Count on Button On click Event
        //    //SemanticScreenReader.Announce(CounterBtn.Text);
        //}
    }

}
