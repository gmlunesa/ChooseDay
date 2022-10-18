using ChooseDay.Models;
using ChooseDay.Services;

namespace ChooseDay.ViewModels
{
    public partial class MyDaysViewModel : BaseViewModel
    {
        MyDayService myDayService;

        // ObservableCollection is used since it has built-in support to raise CollectionChanged
        // OnPropertyChanged does not need to be called
        public ObservableCollection<Day> MyDays { get; } = new();

        // Inject MyDayService through the constructor
        public MyDaysViewModel(MyDayService myDayService)
        {
            Title = "ChooseDay by gmlunesa";
            this.myDayService = myDayService;
        }


        // RelayCommand enables us to bind the command and data between the viewmodel and view
        // Generates GetMyDaysCommand automatically
        [RelayCommand]
        async Task GetMyDaysAsync()
        {
            if (IsBusy)
                return;

            // Toggle IsBusy to true when making calls to the server
            // False when finished with the call to the server
            try
            {
                IsBusy = true;

                var days = await myDayService.GetDays();

                if(MyDays.Count != 0)
                    MyDays.Clear();

                foreach(var day in days)
                    MyDays.Add(day);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!", "Unable to get days.", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
