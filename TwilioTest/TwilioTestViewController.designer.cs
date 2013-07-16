// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace TwilioTest
{
	[Register ("TwilioTestViewController")]
	partial class TwilioTestViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel lblConnectionState { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblDeviceState { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblIsIncoming { get; set; }

		[Action ("btnAccept:")]
		partial void btnAccept (MonoTouch.Foundation.NSObject sender);

		[Action ("btnCall:")]
		partial void btnCall (MonoTouch.Foundation.NSObject sender);

		[Action ("btnHangup:")]
		partial void btnHangup (MonoTouch.Foundation.NSObject sender);

		[Action ("btnIgnore:")]
		partial void btnIgnore (MonoTouch.Foundation.NSObject sender);

		[Action ("btnOne:")]
		partial void btnOne (MonoTouch.Foundation.NSObject sender);

		[Action ("btnReject:")]
		partial void btnReject (MonoTouch.Foundation.NSObject sender);

		[Action ("btnThree:")]
		partial void btnThree (MonoTouch.Foundation.NSObject sender);

		[Action ("btnTwo:")]
		partial void btnTwo (MonoTouch.Foundation.NSObject sender);

		[Action ("swDisconnectSoundEnabled:")]
		partial void swDisconnectSoundEnabled (MonoTouch.Foundation.NSObject sender);

		[Action ("swIncomingSoundEnabled:")]
		partial void swIncomingSoundEnabled (MonoTouch.Foundation.NSObject sender);

		[Action ("swListen:")]
		partial void swListen (MonoTouch.Foundation.NSObject sender);

		[Action ("swMuted:")]
		partial void swMuted (MonoTouch.Foundation.NSObject sender);

		[Action ("swOutgoingSoundEnabled:")]
		partial void swOutgoingSoundEnabled (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (lblDeviceState != null) {
				lblDeviceState.Dispose ();
				lblDeviceState = null;
			}

			if (lblConnectionState != null) {
				lblConnectionState.Dispose ();
				lblConnectionState = null;
			}

			if (lblIsIncoming != null) {
				lblIsIncoming.Dispose ();
				lblIsIncoming = null;
			}
		}
	}
}
