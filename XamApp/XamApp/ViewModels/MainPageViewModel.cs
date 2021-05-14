using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using XamApp.Views;
using Xamarin.Forms;

namespace XamApp.ViewModels
{
   public class MainPageViewModel
    {
        public ICommand GoToLoginCommand { get; set; }
        public MainPageViewModel()
        {
            GoToLoginCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new LoginPage()));
            });

        }
    }
}
