using System;
using TwilioClientCS;
using MonoTouch.Foundation;

namespace TwilioTest
{
	public class ConnectionDelegate : TCConnectionDelegate
	{
		public override void DidFailWithError(TCConnection connection, NSError error) {
			//Console.WriteLine("DidFailWithError: " + error.LocalizedDescription);
		}

//		public override void DidConnect (TCConnection connection)
//		{
//			// NOTE: Don't call the base implementation on a Model class
//			// see http://docs.xamarin.com/ios/tutorials/Events%2c_Protocols_and_Delegates 
//			Console.WriteLine("DidConnect");
//		}
//
//		public override void DidStartConnecting (TCConnection connection)
//		{
//			// NOTE: Don't call the base implementation on a Model class
//			// see http://docs.xamarin.com/ios/tutorials/Events%2c_Protocols_and_Delegates 
//			Console.WriteLine("DidStartConnecting");
//		}
//
//		public override void DidDisconnect (TCConnection connection)
//		{
//			// NOTE: Don't call the base implementation on a Model class
//			// see http://docs.xamarin.com/ios/tutorials/Events%2c_Protocols_and_Delegates 
//			Console.WriteLine("DidDisconnect");
//
//		}
	}}

