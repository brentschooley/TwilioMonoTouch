using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using TwilioClientCS;
using System.Net;
using System.Collections.Generic;

namespace TwilioTest
{
	public partial class TwilioTestViewController : UIViewController
	{
		TCConnection connection;
		TCDevice device;
		DeviceDelegate deviceDelegate;
		ConnectionDelegate connectionDelegate;

		public TwilioTestViewController () : base ("TwilioTestViewController", null)
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
		}

		partial void btnCall (NSObject sender)
		{
			deviceDelegate = new DeviceDelegate ();
			connectionDelegate = new ConnectionDelegate ();

			WebClient client = new WebClient ();
			string token = client.DownloadString ("http://devin.webscript.io/generateToken?clientName=mono&TwimlApp=AP71b92bb5615e4a11b10dffcac9582397");

			device = new TCDevice(token,deviceDelegate);

			NSDictionary param = NSDictionary.FromObjectsAndKeys (
				new object[] { "+14159929754", "+13144586142" },
				new object[] { "Source", "Target" }
			);

			connection = device.Connect(param, connectionDelegate);
		}

		partial void btnHangup (NSObject sender)
		{
			TCConnection conn = (TCConnection)connection;
			conn.Disconnect();
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

