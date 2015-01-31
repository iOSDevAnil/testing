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

namespace FirstDemo_IOS
{
	[Register ("RegistrationVC")]
	partial class RegistrationVC
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnSelectDate { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnSubmit { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtCPassword { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtFirstname { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtLastname { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtPassword { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtUsername { get; set; }

		[Action ("btnSelectDate_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnSelectDate_TouchUpInside (UIButton sender);

		[Action ("btnSubmit_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnSubmit_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnSelectDate != null) {
				btnSelectDate.Dispose ();
				btnSelectDate = null;
			}
			if (btnSubmit != null) {
				btnSubmit.Dispose ();
				btnSubmit = null;
			}
			if (txtCPassword != null) {
				txtCPassword.Dispose ();
				txtCPassword = null;
			}
			if (txtFirstname != null) {
				txtFirstname.Dispose ();
				txtFirstname = null;
			}
			if (txtLastname != null) {
				txtLastname.Dispose ();
				txtLastname = null;
			}
			if (txtPassword != null) {
				txtPassword.Dispose ();
				txtPassword = null;
			}
			if (txtUsername != null) {
				txtUsername.Dispose ();
				txtUsername = null;
			}
		}
	}
}
