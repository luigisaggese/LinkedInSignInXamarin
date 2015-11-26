// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace LinkedInSignInSample
{
	[Register ("ApiResponseViewController")]
	partial class ApiResponseViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel requestMethodLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel requestUrlLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel responseStatusLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView responseTextView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (requestMethodLabel != null) {
				requestMethodLabel.Dispose ();
				requestMethodLabel = null;
			}
			if (requestUrlLabel != null) {
				requestUrlLabel.Dispose ();
				requestUrlLabel = null;
			}
			if (responseStatusLabel != null) {
				responseStatusLabel.Dispose ();
				responseStatusLabel = null;
			}
			if (responseTextView != null) {
				responseTextView.Dispose ();
				responseTextView = null;
			}
		}
	}
}
