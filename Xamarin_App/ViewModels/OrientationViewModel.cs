using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin_App.Services;

namespace Xamarin_App.ViewModels
{
    public class OrientationViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.Title;
        public ICommand SpeakCommand { get; }
        public ICommand GetDeviceOrientation { get; }
        private IDeviceOrientationService _deviceOrientationService;
        public string Orientation { get; set; }
        public string Text { get; set; }

        public OrientationViewModel(INavigationService navigationService, IPageDialogService pageDialogService,
           IDeviceOrientationService deviceOrientationService) : base(navigationService, pageDialogService)
        {
            _deviceOrientationService = deviceOrientationService;
            GetDeviceOrientation = new DelegateCommand(GetOrientation);
        }

        public void GetOrientation()
        {
            var orientation = _deviceOrientationService.GetOrientation();
            Orientation = orientation.ToString();
        }
    }
}
