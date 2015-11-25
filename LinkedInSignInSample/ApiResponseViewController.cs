using System;
using Foundation;
using UIKit;

using LinkedIn.SignIn;

namespace LinkedInSignInSample
{
	partial class ApiResponseViewController : UIViewController
	{
		public ApiResponseViewController (IntPtr handle)
			: base (handle)
		{
		}

		public ApiResponse Response { get; set; }

		public ApiError Error { get; set; }

		public string Method { get; set; }

		public string Url { get; set; }

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			responseTextView.Layer.BorderWidth = 1;
			responseTextView.Layer.BorderColor = UIColor.Gray.CGColor;
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			requestMethodLabel.Text = Method;
			requestUrlLabel.Text = Url;
			if (Response != null) {
				responseStatusLabel.Text = Response.StatusCode.ToString ();
				responseTextView.Text = Response.Data;
			} else if (Error != null) {
				responseTextView.Text = Error.Description;
			}
		}

		public override void TouchesBegan (NSSet touches, UIEvent evt)
		{
			var touch = evt.AllTouches.ToArray<UITouch> () [0];
			if (responseTextView.IsFirstResponder && touch.View != responseTextView) {
				responseTextView.ResignFirstResponder ();
			}

			base.TouchesBegan (touches, evt);
		}
	}
}
