using System;
using UIKit;

namespace TestControllerDisposal
{
	public partial class ViewController : UIViewController
	{
		UIScrollView scroll;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			scroll = new UIScrollView();
			scroll.WeakDelegate = this;
			View.AddSubview(scroll);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			Console.WriteLine("Disposing View Controller");
		}
	}
}
