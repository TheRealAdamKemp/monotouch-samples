using System;
using UIKit;
using Foundation;

namespace AVCam
{
	public class AppDelegate : UIResponder
	{
		public UIWindow window { get; set; }

		public bool ApplicationDidFinishLaunchingWithOptions (UIApplication application, NSDictionary launchOptions)
		{
			// [UIDevice currentDevice] beginGeneratingDeviceOrientationNotifications];
			// return YES;
		}

		public void ApplicationWillTerminate (UIApplication application)
		{
			// [UIDevice currentDevice] endGeneratingDeviceOrientationNotifications];
		}

		public void ApplicationWillEnterForeground (UIApplication application)
		{
			// [UIDevice currentDevice] beginGeneratingDeviceOrientationNotifications];
		}

		public void ApplicationDidEnterBackground (UIApplication application)
		{
			// [UIDevice currentDevice] endGeneratingDeviceOrientationNotifications];
		}
	}
}