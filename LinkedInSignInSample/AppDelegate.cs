using Foundation;
using UIKit;

using LinkedIn.SignIn;

namespace LinkedInSignInSample
{
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public override UIWindow Window { get; set; }

		public override bool OpenUrl (UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
		{
			if (CallbackHandler.ShouldHandleUrl (url)) {
				CallbackHandler.OpenUrl (application, url, sourceApplication, annotation);
			}
			return true;
		}
	}
}
