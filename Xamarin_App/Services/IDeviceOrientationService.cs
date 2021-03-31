using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace Xamarin_App.Services
{
    public interface IDeviceOrientationService
    {
        DeviceOrientation GetOrientation();
    }
}
