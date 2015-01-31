
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace FirstDemo_IOS
{
	public partial class RegistrationVC : UIViewController
	{

		public RegistrationVC () : base ("RegistrationVC", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			btnSubmit.TouchUpInside += (object sender, EventArgs e) => {
				UIAlertView alert = new UIAlertView ("Title", "The message", null, "OK", null);
				alert.Show();
			};

		}
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}


		partial void btnSubmit_TouchUpInside (UIButton sender)
		{
			UIAlertView alert = new UIAlertView ("Title", "The message", null, "OK", null);
			alert.Show();
			throw new NotImplementedException ();
		}

		partial void btnSelectDate_TouchUpInside (UIButton sender)
		{
			UIAlertView alert = new UIAlertView ("Title", "The message", null, "OK", null);
			alert.Show();
			throw new NotImplementedException ();
			//var alert = new UIAlertView("Alert","BtnSelect Date Clicked",null,"ok",null);
			//alert.Show();
		}
	}
}

