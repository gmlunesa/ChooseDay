using ChooseDay.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChooseDay.ViewModels
{
    public partial class MyDaysViewModel : ObservableObject
    {
        [ObservableProperty]
        List<Day> days;

        public MyDaysViewModel()
        {
            LoadDays();
        }

        [RelayCommand]
        public void LoadDays()
        {
            Days = new List<Day>() {
                new Day {
                    Name = "Breather Time",
                    Description = "Recovery is important. Please take this day to let our mind and muscles heal from a hectic schedule.",
                    Activities = new List<string> {"Yoga", "Meditation", "Reflection"},
                    Image = new Uri("https://images.unsplash.com/photo-1597573337211-e1080012b84b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=627&q=80")
                },
                new Day {
                    Name = "Intensity Increase",
                    Description = "Self-improvement is a lifelong journey. Let's continously achieve new heights, as we are our own competition.",
                    Activities = new List<string> {"HIIT", "Protein Meals"},
                    Image = new Uri("https://images.unsplash.com/photo-1500468756762-a401b6f17b46?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=688&q=80")
                },
                new Day {
                    Name = "Refeed Quench",
                    Description = "Hard work throughout a week makes one deserving for a treat! Relax and indulge with an extra slice.",
                    Activities = new List<string> {"Long walk", "Extra dessert"},
                    Image = new Uri("https://images.unsplash.com/photo-1511688878353-3a2f5be94cd7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80")
                },

            };

        }
    }
}
