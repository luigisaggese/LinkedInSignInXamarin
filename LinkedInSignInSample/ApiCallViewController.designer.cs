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
	[Register ("ApiCallViewController")]
	partial class ApiCallViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView bodyTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl methodTypeControl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField resourceTextField { get; set; }

		[Action ("OnExecuteRequest:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void OnExecuteRequest (UIBarButtonItem sender);

		void ReleaseDesignerOutlets ()
		{
			if (bodyTextField != null) {
				bodyTextField.Dispose ();
				bodyTextField = null;
			}
			if (methodTypeControl != null) {
				methodTypeControl.Dispose ();
				methodTypeControl = null;
			}
			if (resourceTextField != null) {
				resourceTextField.Dispose ();
				resourceTextField = null;
			}
		}
	}
}
