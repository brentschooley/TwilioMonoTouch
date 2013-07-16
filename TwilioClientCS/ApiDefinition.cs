using System;

using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace TwilioClientCS {

	[Model, BaseType (typeof (NSObject))]
	public partial interface TCConnectionDelegate {

		[Export ("connection:didFailWithError:"), Abstract, EventArgs ("DidFailWithError"), EventName("FailedWithError")]
		void DidFailWithError (TCConnection connection, NSError error);

		[Export ("connectionDidStartConnecting:"),EventArgs ("DidStartConnecting"), EventName("StartedConnecting")]
		void DidStartConnecting (TCConnection connection);

		[Export ("connectionDidConnect:"),EventArgs ("DidConnect"), EventName("Connected")]
		void DidConnect (TCConnection connection);

		[Export ("connectionDidDisconnect:"),EventArgs ("DidDisconnect"), EventName("Disconnected")]
		void DidDisconnect (TCConnection connection);
	}
	
	[BaseType (typeof (NSObject),
	 Delegates=new string [] { "WeakDelegate" },
	 Events=new Type [] { typeof(TCConnectionDelegate)})]
	public partial interface TCConnection {

		[Export ("state")]
		TCConnectionState State { get; }

		[Export ("incoming")]
		bool Incoming { [Bind ("isIncoming")] get; }

		[Export ("parameters")]
		NSDictionary Parameters { get; }

		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get;set; }

		[Wrap ("WeakDelegate")][NullAllowed]
		TCConnectionDelegate Delegate { get; set; }

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

		[Export ("device:didStopListeningForIncomingConnections:"), Abstract, EventArgs("DidStopListeningForIncomingConnections"), EventName("StoppedListeningForIncomingConnections")]
		void DidStopListeningForIncomingConnections (TCDevice device, NSError error);

		[Export ("deviceDidStartListeningForIncomingConnections:"),EventArgs ("DidStartListeningForIncomingConnections"), EventName("StartedListeningForIncomingConnections")]
		void DidStartListeningForIncomingConnections (TCDevice device);

		[Export ("device:didReceiveIncomingConnection:"),EventArgs ("DidReceiveIncomingConnection"), EventName("ReceivedIncomingConnection")]
		void DidReceiveIncomingConnection (TCDevice device, TCConnection connection);

		[Export ("device:didReceivePresenceUpdate:"),EventArgs ("DidReceivePresenceUpdate"), EventName("ReceivedPresenceUpdate")]
		void DidReceivePresenceUpdate (TCDevice device, TCPresenceEvent presenceEvent);
	}
	
	[BaseType (typeof (NSObject),
	 Delegates=new string [] { "WeakDelegate" },
	 Events=new Type [] { typeof(TCDeviceDelegate)})]
	public partial interface TCDevice {

		[Export ("state")]
		TCDeviceState State { get; }

		[Export ("capabilities")]
		NSDictionary Capabilities { get; }

		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject Delegate { get; set; }

		[Wrap ("WeakDelegate")][NullAllowed]
		TCDeviceDelegate WeakDelegate {get;set;}

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

		[Export ("connect:delegate:")][Internal]
		IntPtr Connect_ (NSDictionary parameters, TCConnectionDelegate d);

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
