using System;
using Foundation;
using UIKit;

using LinkedIn.SignIn;

namespace LinkedInSignInSample
{
	partial class ApiCallViewController : UIViewController
	{
		private ApiResponse lastResponse;
		private ApiError lastError;
		private string lastMethod;
		private string lastUrl;

		public ApiCallViewController (IntPtr handle)
			: base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			resourceTextField.Text = ApiHelper.LinkedInApiUrl;

			bodyTextField.Layer.BorderWidth = 1;
			bodyTextField.Layer.BorderColor = UIColor.Gray.CGColor;
		}

		partial void OnExecuteRequest (UIBarButtonItem sender)
		{
			lastResponse = null;
			lastError = null;

			var method = methodTypeControl.TitleAt (methodTypeControl.SelectedSegment);
			var resource = resourceTextField.Text;
			var body = bodyTextField.Text;

			Console.WriteLine ("Execute called with {0} body {1} and {2}", resource, body, method);

			// save state when request was made
			ApiHelper.SharedInstance.ApiRequest (resource, method, NSData.FromString (body, NSStringEncoding.UTF8),
				response => {
					Console.WriteLine ("Success called: " + response.Data);
					lastMethod = method;
					lastResponse = response;
					lastUrl = resource;
					InvokeOnMainThread (() => PerformSegue ("ShowApiResponsePage", this));
				},
				apiError => {
					Console.WriteLine ("Error called: " + apiError.Description);
					lastMethod = method;
					lastResponse = apiError.ErrorResponse;
					lastError = apiError;
					lastUrl = resource;
					InvokeOnMainThread (() => PerformSegue ("ShowApiResponsePage", this));
				});
		}

		public override void TouchesBegan (NSSet touches, UIEvent evt)
		{
			var touch = evt.AllTouches.ToArray<UITouch> () [0];
			if (resourceTextField.IsFirstResponder && touch.View != resourceTextField) {
				resourceTextField.ResignFirstResponder ();
			}
			if (bodyTextField.IsFirstResponder && touch.View != bodyTextField) {
				bodyTextField.ResignFirstResponder ();
			}

			base.TouchesBegan (touches, evt);
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue (segue, sender);

			var responseController = segue.DestinationViewController as ApiResponseViewController;
			if (responseController != null && lastResponse != null) {
				responseController.Error = lastError;
				responseController.Method = lastMethod;
				responseController.Response	= lastResponse;
				responseController.Url	= lastUrl;
			}
		}
	}
}
