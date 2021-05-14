using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamApp.Services;
using XamApp.ViewModels;
using XamApp.Views.ContentViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        private View[] views;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
            views = new View[]
            {
                new AddictionsView(),
                new DepresionView(),
                new SupportView()

            };

            OnBoardingCarousel.ItemsSource = views;
        }

        private void OnBoardingCarousel_PositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {
            var currentView = views[e.NewValue];

            if (currentView is IAnimatedView animatedView )
            {
                animatedView.StartAnimation();
            }
        }
    }
}
