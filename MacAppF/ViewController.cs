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
            try
            {
                var num = TextOutlet.StringValue;
                int number = Convert.ToInt32(num);
                var alert = new NSAlert()
                {
                    AlertStyle = NSAlertStyle.Informational,
                    InformativeText = $"Ви ввели число {number}",
                    MessageText = "Повідомлення",
                };
                alert.RunModal();
            }
            catch (FormatException)
            {
                var alert = new NSAlert()
                {
                    AlertStyle = NSAlertStyle.Informational,
                    InformativeText = $"Помилка введення - неправильний формат",
                    MessageText = "Повідомлення",
                };
                alert.RunModal();
            }
            
        }
    }
}
