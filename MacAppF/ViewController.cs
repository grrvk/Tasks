using System;

using AppKit;
using Foundation;

namespace MacAppF
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

        partial void ButtonAction(NSObject sender)
        {
			var number = TextOutlet.IntValue;
            var alert = new NSAlert()
            {
                AlertStyle = NSAlertStyle.Informational,
                InformativeText = $"Ви ввели число {number}",
				MessageText = "Повідомлення",
            };
            alert.RunModal();
        }
    }
}
