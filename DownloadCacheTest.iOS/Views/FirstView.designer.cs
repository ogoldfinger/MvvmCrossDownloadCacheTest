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

namespace DownloadCacheTest.iOS.Views
{
	[Register ("FirstView")]
	partial class FirstView
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imgTest { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Label { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField TextField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (imgTest != null) {
				imgTest.Dispose ();
				imgTest = null;
			}
			if (Label != null) {
				Label.Dispose ();
				Label = null;
			}
			if (TextField != null) {
				TextField.Dispose ();
				TextField = null;
			}
		}
	}
}
