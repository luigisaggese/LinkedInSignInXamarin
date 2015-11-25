using System;
using Foundation;
using UIKit;

using LinkedIn.SignIn;

namespace LinkedInSignInSample
{
	public partial class ViewController : UITableViewController
	{
		public ViewController (IntPtr handle)
			: base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			UpdateToken ();
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			tableView.DeselectRow (indexPath, true);

			if (indexPath.Section == 0) {
				// Session
				if (indexPath.Row == 0) {
					// Sign In
					SessionManager.CreateSession (
						new []{ Permission.BasicProfile, Permission.EmailAddress },
						"some state",
						true,
						returnState => {
							Console.WriteLine ("Sign in was successful: " + returnState);

							var session = SessionManager.SharedInstance.Session;
							Console.WriteLine ("Session value: {0}; valid: {1}", session.Value, session.IsValid);

							var token = session.AccessToken.Description;
							Console.WriteLine ("Access token: " + token);

							UpdateToken ();
						},
						error => {
							Console.WriteLine ("Sign in failed: " + error.Description);
							UpdateToken ();
						}
					);
				} else if (indexPath.Row == 1) {
					// Clear Session
					SessionManager.ClearSession ();
					UpdateToken ();
				} else if (indexPath.Row == 2) {
					// Access Token
				}
			} else if (indexPath.Section == 1) {
				// Features
				if (indexPath.Row == 0) {
					// API Call
				} else if (indexPath.Row == 1) {
					// Deeplink
				}
			}
		}

		private void UpdateToken ()
		{
			if (SessionManager.HasValidSession) {
				var token = SessionManager.SharedInstance.Session.AccessToken;
				var cell = TableView.CellAt (NSIndexPath.FromRowSection (2, 0));
				cell.DetailTextLabel.Text = token.Description;
			}	
		}
	}
}

