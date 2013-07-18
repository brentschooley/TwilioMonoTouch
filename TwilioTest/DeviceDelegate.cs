using System;
using TwilioClientCS;
using MonoTouch.Foundation;

namespace TwilioTest
{
	public class DeviceDelegate : TCDeviceDelegate
	{
		public override void DidStopListeningForIncomingConnections(TCDevice device, NSError error) {
			//Console.WriteLine("DidStopListeningForIncomingConnection");
		}

//		public override void DidReceiveIncomingConnection (TCDevice device, TCConnection connection)
//		{
//			// NOTE: Don't call the base implementation on a Model class
//			// see http://docs.xamarin.com/ios/tutorials/Events%2c_Protocols_and_Delegates 
//			Console.WriteLine("DidReceiveIncomingConnection");
//		}
//
//		public override void DidStartListeningForIncomingConnections (TCDevice device)
//		{
//			// NOTE: Don't call the base implementation on a Model class
//			// see http://docs.xamarin.com/ios/tutorials/Events%2c_Protocols_and_Delegates 
//			Console.WriteLine("DidStartListeningForIncomingConnections");
//		}
//
//		public override void DidReceivePresenceUpdate (TCDevice device, TCPresenceEvent presenceEvent)
//		{
//			// NOTE: Don't call the base implementation on a Model class
//			// see http://docs.xamarin.com/ios/tutorials/Events%2c_Protocols_and_Delegates 
//			Console.WriteLine("DidReceivePresenceUpdate");
//		}


	}
}

