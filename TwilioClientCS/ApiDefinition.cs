using System;

using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace TwilioClientCS {

	[Model, BaseType (typeof (NSObject))]
	public partial interface TCConnectionDelegate {

		[Export ("connection:didFailWithError:"), Abstract]
		void DidFailWithError (TCConnection connection, NSError error);

		[Export ("connectionDidStartConnecting:")]
		void DidStartConnecting (TCConnection connection);

		[Export ("connectionDidConnect:")]
		void DidConnect (TCConnection connection);

		[Export ("connectionDidDisconnect:")]
		void DidDisconnect (TCConnection connection);
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface TCConnection {

		[Export ("state")]
		TCConnectionState State { get; }

		[Export ("incoming")]
		bool Incoming { [Bind ("isIncoming")] get; }

		[Export ("parameters")]
		NSDictionary Parameters { get; }

		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		TCConnectionDelegate WeakDelegate { get;set; }

		[Export ("muted")]
		bool Muted { [Bind ("isMuted")] get; set; }

		[Export ("accept")]
		void Accept ();

		[Export ("ignore")]
		void Ignore ();

		[Export ("reject")]
		void Reject ();

		[Export ("disconnect")]
		void Disconnect ();

		[Export ("sendDigits:")]
		void SendDigits (string digits);
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface TCDeviceDelegate {

		[Export ("device:didStopListeningForIncomingConnections:"), Abstract]
		void DidStopListeningForIncomingConnections (TCDevice device, NSError error);

		[Export ("deviceDidStartListeningForIncomingConnections:")]
		void DidStartListeningForIncomingConnections (TCDevice device);

		[Export ("device:didReceiveIncomingConnection:")]
		void DidReceiveIncomingConnection (TCDevice device, TCConnection connection);

		[Export ("device:didReceivePresenceUpdate:")]
		void DidReceivePresenceUpdate (TCDevice device, TCPresenceEvent presenceEvent);
	}
	
	[BaseType (typeof (NSObject))]
	public partial interface TCDevice {

		[Export ("state")]
		TCDeviceState State { get; }

		[Export ("capabilities")]
		NSDictionary Capabilities { get; }

		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		TCDeviceDelegate Delegate { get; set; }

		[Export ("incomingSoundEnabled")]
		bool IncomingSoundEnabled { get; set; }

		[Export ("outgoingSoundEnabled")]
		bool OutgoingSoundEnabled { get; set; }

		[Export ("disconnectSoundEnabled")]
		bool DisconnectSoundEnabled { get; set; }

		[Export ("initWithCapabilityToken:delegate:")]
		IntPtr Constructor (string capabilityToken, [NullAllowed]TCDeviceDelegate d);

		[Export ("listen")]
		void Listen ();

		[Export ("unlisten")]
		void Unlisten ();

		[Export ("updateCapabilityToken:")]
		void UpdateCapabilityToken (string capabilityToken);

		// This fails if I try to return a real TCConnection object, I think because
		// we are actually getting a TCConnectionInternal back.  Need to verify that.
		[Export ("connect:delegate:")][Internal]
		IntPtr Connect_ (NSDictionary parameters, TCConnectionDelegate d);

		//TCConnection Connect ([NullAllowed]NSDictionary parameters, [NullAllowed]TCConnectionDelegate d);

		[Export ("disconnectAll")]
		void DisconnectAll ();
	}

	[BaseType (typeof (NSObject))]
	public partial interface TCPresenceEvent {

		[Export ("name")]
		string Name { get; }

		[Export ("available")]
		bool Available { [Bind ("isAvailable")] get; }
	}
}
