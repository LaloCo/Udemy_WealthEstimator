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

namespace Wealth_Estimator.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton calculateButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField compoundingTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel interestLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField interestTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel investmentLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField investmentTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel moneyLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel summaryLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField yearsTextField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (calculateButton != null) {
				calculateButton.Dispose ();
				calculateButton = null;
			}
			if (compoundingTextField != null) {
				compoundingTextField.Dispose ();
				compoundingTextField = null;
			}
			if (interestLabel != null) {
				interestLabel.Dispose ();
				interestLabel = null;
			}
			if (interestTextField != null) {
				interestTextField.Dispose ();
				interestTextField = null;
			}
			if (investmentLabel != null) {
				investmentLabel.Dispose ();
				investmentLabel = null;
			}
			if (investmentTextField != null) {
				investmentTextField.Dispose ();
				investmentTextField = null;
			}
			if (moneyLabel != null) {
				moneyLabel.Dispose ();
				moneyLabel = null;
			}
			if (summaryLabel != null) {
				summaryLabel.Dispose ();
				summaryLabel = null;
			}
			if (yearsTextField != null) {
				yearsTextField.Dispose ();
				yearsTextField = null;
			}
		}
	}
}
