using System;
using Foundation;
using UIKit;

using LinkedIn.SignIn;

namespace LinkedInSignInSample
{
	partial class DeeplinkViewController : UIViewController
	{
		public DeeplinkViewController (IntPtr handle)
			: base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			memberIdText.Layer.BorderWidth = 1;
			memberIdText.Layer.BorderColor = UIColor.Gray.CGColor;
		}

		partial void OnViewMemberProfile (UIButton sender)
		{
			Console.WriteLine ("viewProfileButton clicked");

			if (string.IsNullOrEmpty (memberIdText.Text)) {
				DeeplinkHelper.SharedInstance.ViewCurrentProfile ("viewMyProfileButton", true, returnedState => {
					Console.WriteLine ("Success: " + returnedState);
				}, (error, returnedState) => {
					Console.WriteLine ("Error: state={0}; error={1}", returnedState, error);
				});
			} else {
				DeeplinkHelper.SharedInstance.ViewOtherProfile (memberIdText.Text, "viewMemberProfileButton", true, returnedState => {
					Console.WriteLine ("Success: " + returnedState);
				}, (error, returnedState) => {
					Console.WriteLine ("Error: state={0}; error={1}", returnedState, error);
				});
			}
		}

		public override void TouchesBegan (NSSet touches, UIEvent evt)
		{
			var touch = evt.AllTouches.ToArray<UITouch> () [0];
			if (errorsTextView.IsFirstResponder && touch.View != errorsTextView) {
				errorsTextView.ResignFirstResponder ();
			}

			base.TouchesBegan (touches, evt);
		}
	}
}
