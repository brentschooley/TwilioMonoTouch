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
			string token = client.DownloadString ("http://devin.webscript.io/generateToken?ClientName=mono&TwimlApp=APd5e7f789da788fd4b1785353de3cfbf9");

//			device = new TCDevice(token,deviceDelegate);

			// HACK:
			// The delegate param should be null if you want to use events pattern instead of custom delegate pattern
			// this is because when you set up an event we internally will create a Objc delegate that will be assigned to the delegate property
			// and if we see that delegate property is not null then we will not be able to set you up

			// You might find this reading interesting 
			// http://docs.xamarin.com/guides/ios/application_fundamentals/delegates%2C_protocols%2C_and_events

			device = new TCDevice(token, null);

			Console.WriteLine("Inbound: " + device.Capabilities["incoming"].ToString());
			Console.WriteLine("Outbound: " + device.Capabilities["outgoing"].ToString());

			updateStateLabels ();
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
				updateStateLabels();
			};

			device.StartedListeningForIncomingConnections += delegate 
			{
				Console.WriteLine("StartedListeningForIncomingConnections"); 
				updateStateLabels();
			};

			device.ReceivedIncomingConnection += (s,a) => 
			{
				Console.WriteLine("ReceivedIncomingConnection"); 

				if (connection!=null && connection.State == TCConnectionState.Connected)
				{
					connection.Disconnect();
				}

				connection = a.Connection;

				updateStateLabels();
			};

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
				updateStateLabels();
			};
			connection.StartedConnecting += delegate 
			{
				Console.WriteLine("StartedConnecting"); 
				updateStateLabels();
			};
			connection.Connected += delegate 
			{
				Console.WriteLine("Connected"); 
				updateStateLabels();
			};
			connection.Disconnected += delegate 
			{
				Console.WriteLine("Disconnected"); 
				updateStateLabels();
				connection = null;
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
			if (connection !=null && (connection.State == TCConnectionState.Connected || connection.State == TCConnectionState.Connecting))
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

		private void updateStateLabels() {
			string stateString;

			stateString = device.State.ToString ();
			Console.WriteLine("updateStateLabels: " + stateString);
			InvokeOnMainThread(delegate {
				this.lblDeviceState.Text = stateString;
			});

			if (connection != null) {
				stateString = connection.State.ToString ();
				Console.WriteLine ("updateStateLabels: " + stateString);
				InvokeOnMainThread (delegate {
					this.lblConnectionState.Text = stateString;
				});
			}
		}
	}
}

