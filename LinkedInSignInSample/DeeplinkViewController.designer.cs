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
	[Register ("DeeplinkViewController")]
	partial class DeeplinkViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView errorsTextView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField memberIdText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton viewProfileButton { get; set; }

		[Action ("OnViewMemberProfile:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void OnViewMemberProfile (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (errorsTextView != null) {
				errorsTextView.Dispose ();
				errorsTextView = null;
			}
			if (memberIdText != null) {
				memberIdText.Dispose ();
				memberIdText = null;
			}
			if (viewProfileButton != null) {
				viewProfileButton.Dispose ();
				viewProfileButton = null;
			}
		}
	}
}
