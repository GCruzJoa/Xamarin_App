using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_App.ViewModels;

namespace Xamarin_App
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync(Config.Home);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage, OrientationViewModel>();
            containerRegistry.RegisterForNavigation<NavigationPage>(Config.Navigate);
        }
    }
}
