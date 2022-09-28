using System;

using AppKit;
using Foundation;

namespace MacApp
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

        partial void ButtonContl(NSObject sender)
        {
			var Text = TextOutlet.StringValue;
			int number = Convert.ToInt32(Text);
			string data = $"Ви ввели число {number}";
			Console.WriteLine(data);
        }
    }
}
