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

			WebClient client = new WebClient ();
			string token = client.DownloadString ("http://devin.webscript.io/generateToken?clientName=mono&TwimlApp=AP71b92bb5615e4a11b10dffcac9582397");

			//			device = new TCDevice(token,deviceDelegate);

			// HACK:
			// The delegate param should be null if you want to use events pattern instead of custom delegate pattern
			// this is because when you set up an event we internally will create a Objc delegate that will be assigned to the delegate property
			// and if we see that delegate property is not null then we will not be able to set you up

			// You might find this reading interesting 
			// http://docs.xamarin.com/guides/ios/application_fundamentals/delegates%2C_protocols%2C_and_events

			device = new TCDevice(token, null);
		}

		#region TCDevice

		partial void swDisconnectSoundEnabled (NSObject sender)
		{
			if (device!=null) {
				device.DisconnectSoundEnabled = ((UISwitch)sender).On;
			}

			Console.WriteLine("disconnectSoundEnabled: " + device.DisconnectSoundEnabled);
		}

		partial void swIncomingSoundEnabled (NSObject sender)
		{
			if (device!=null) {
				device.IncomingSoundEnabled = ((UISwitch)sender).On;
			}

			Console.WriteLine("incomingSoundEnabled: " + device.IncomingSoundEnabled);
		}

		partial void swOutgoingSoundEnabled (NSObject sender)
		{
			if (device!=null) {
				device.OutgoingSoundEnabled = ((UISwitch)sender).On;
			}

			Console.WriteLine("outgoingSoundEnabled: " + device.OutgoingSoundEnabled);
		}

		partial void swListen (NSObject sender)
		{
			if (device!=null) 
			{
				if (((UISwitch)sender).On) 
				{
					device.Listen();
				}
				else 
				{
					device.Unlisten();
				}
			}

			Console.WriteLine("listen: " + ((UISwitch)sender).On);
		}

		partial void btnCall (NSObject sender)
		{
			device.StoppedListeningForIncomingConnections += delegate {
				Console.WriteLine("StoppedListeningForIncomingConnection"); 
			};

			device.StartedListeningForIncomingConnections += delegate 
			{
				Console.WriteLine("StartedListeningForIncomingConnections"); 
			};

			device.ReceivedIncomingConnection += delegate { Console.WriteLine("ReceivedIncomingConnection"); };
			device.ReceivedPresenceUpdate += delegate { Console.WriteLine("ReceivedPresenceUpdate"); };

			NSDictionary param = NSDictionary.FromObjectsAndKeys (
				new object[] { "+14159929754", "+13144586142" },
			new object[] { "Source", "Target" }
			);

			// HACK: 
			// In order to setup events you need to first initialize connection so we have a reference to it, also the delegate param should be null
			// this is because when you set up an event we internally will create a Objc delegate that will be assigned to the delegate property
			// and if we see that delegate property is not null then we will not be able to set you up

			connection = device.Connect(param, null);

			connection.Failed += delegate 
			{
				Console.WriteLine("FailedWithError"); 
			};
			connection.StartedConnecting += delegate 
			{
				Console.WriteLine("StartedConnecting"); 
			};
			connection.Connected += delegate 
			{
				Console.WriteLine("Connected"); 
			};
			connection.Disconnected += delegate 
			{
				Console.WriteLine("Disconnected"); 
			};
		}

		#endregion

		#region TCConnection

		partial void swMuted (NSObject sender)
		{
			if (connection !=null && connection.State == TCConnectionState.Connected)
			{
				connection.Muted = ((UISwitch)sender).On;

				Console.WriteLine("muted: " + connection.Muted);
			}
		}

		partial void btnHangup (NSObject sender)
		{
			if (connection !=null && connection.State == TCConnectionState.Connected)
			{
				connection.Disconnect();
			}
		}

		partial void btnAccept (NSObject sender)
		{
			if (connection!=null)
			{
				connection.Accept();
			}
		}

		partial void btnIgnore (NSObject sender)
		{
			if (connection!=null)
			{
				connection.Ignore();
			}
		}

		partial void btnReject (NSObject sender)
		{
			if (connection!=null)
			{
				connection.Reject();
			}
		}

		partial void btnOne (NSObject sender)
		{
			if (connection !=null && connection.State == TCConnectionState.Connected)
			{
				connection.SendDigits("1");

				Console.WriteLine("send digits: 1");
			}
		}

		partial void btnTwo (NSObject sender)
		{
			if (connection !=null && connection.State == TCConnectionState.Connected)
			{
				connection.SendDigits("2");

				Console.WriteLine("send digits: 2");
			}
		}

		partial void btnThree (NSObject sender)
		{
			if (connection !=null && connection.State == TCConnectionState.Connected)
			{
				connection.SendDigits("3");

				Console.WriteLine("send digits: 2");
			}
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

		#endregion

		//		private void updateStateLabels {
		//			string stateString;
		//
		//			stateString = [self convertDeviceToString:[[self device] state] ];
		//			Console.WriteLine("updateStateLabels: " + stateString);
		//			[[self lblDeviceState] setText:stateString];
		//
		//			stateString = [self convertConnectionToString:[[self connection] state] ];
		//			Console.WriteLine("updateStateLabels: " + stateString);
		//			[[self lblConnectionState] setText:stateString];
		//		}
	}
}

