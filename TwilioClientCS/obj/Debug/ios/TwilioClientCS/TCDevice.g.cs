//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace TwilioClientCS {
	[Register("TCDevice", true)]
	public unsafe partial class TCDevice : NSObject {
		[CompilerGenerated]
		const string selState = "state";
		static readonly IntPtr selStateHandle = Selector.GetHandle ("state");
		[CompilerGenerated]
		const string selCapabilities = "capabilities";
		static readonly IntPtr selCapabilitiesHandle = Selector.GetHandle ("capabilities");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selIncomingSoundEnabled = "incomingSoundEnabled";
		static readonly IntPtr selIncomingSoundEnabledHandle = Selector.GetHandle ("incomingSoundEnabled");
		[CompilerGenerated]
		const string selSetIncomingSoundEnabled_ = "setIncomingSoundEnabled:";
		static readonly IntPtr selSetIncomingSoundEnabled_Handle = Selector.GetHandle ("setIncomingSoundEnabled:");
		[CompilerGenerated]
		const string selOutgoingSoundEnabled = "outgoingSoundEnabled";
		static readonly IntPtr selOutgoingSoundEnabledHandle = Selector.GetHandle ("outgoingSoundEnabled");
		[CompilerGenerated]
		const string selSetOutgoingSoundEnabled_ = "setOutgoingSoundEnabled:";
		static readonly IntPtr selSetOutgoingSoundEnabled_Handle = Selector.GetHandle ("setOutgoingSoundEnabled:");
		[CompilerGenerated]
		const string selDisconnectSoundEnabled = "disconnectSoundEnabled";
		static readonly IntPtr selDisconnectSoundEnabledHandle = Selector.GetHandle ("disconnectSoundEnabled");
		[CompilerGenerated]
		const string selSetDisconnectSoundEnabled_ = "setDisconnectSoundEnabled:";
		static readonly IntPtr selSetDisconnectSoundEnabled_Handle = Selector.GetHandle ("setDisconnectSoundEnabled:");
		[CompilerGenerated]
		const string selInitWithCapabilityTokenDelegate_ = "initWithCapabilityToken:delegate:";
		static readonly IntPtr selInitWithCapabilityTokenDelegate_Handle = Selector.GetHandle ("initWithCapabilityToken:delegate:");
		[CompilerGenerated]
		const string selListen = "listen";
		static readonly IntPtr selListenHandle = Selector.GetHandle ("listen");
		[CompilerGenerated]
		const string selUnlisten = "unlisten";
		static readonly IntPtr selUnlistenHandle = Selector.GetHandle ("unlisten");
		[CompilerGenerated]
		const string selUpdateCapabilityToken_ = "updateCapabilityToken:";
		static readonly IntPtr selUpdateCapabilityToken_Handle = Selector.GetHandle ("updateCapabilityToken:");
		[CompilerGenerated]
		const string selConnectDelegate_ = "connect:delegate:";
		static readonly IntPtr selConnectDelegate_Handle = Selector.GetHandle ("connect:delegate:");
		[CompilerGenerated]
		const string selDisconnectAll = "disconnectAll";
		static readonly IntPtr selDisconnectAllHandle = Selector.GetHandle ("disconnectAll");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TCDevice");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TCDevice () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public TCDevice (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCDevice (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCDevice (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithCapabilityToken:delegate:")]
		[CompilerGenerated]
		public TCDevice (string capabilityToken, TCDeviceDelegate d)
			: base (NSObjectFlag.Empty)
		{
			if (capabilityToken == null)
				throw new ArgumentNullException ("capabilityToken");
			var nscapabilityToken = NSString.CreateNative (capabilityToken);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithCapabilityTokenDelegate_Handle, nscapabilityToken, d == null ? IntPtr.Zero : d.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithCapabilityTokenDelegate_Handle, nscapabilityToken, d == null ? IntPtr.Zero : d.Handle);
			}
			NSString.ReleaseNative (nscapabilityToken);
			
		}
		
		[Export ("listen")]
		[CompilerGenerated]
		public virtual void Listen ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selListenHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selListenHandle);
			}
		}
		
		[Export ("unlisten")]
		[CompilerGenerated]
		public virtual void Unlisten ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUnlistenHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUnlistenHandle);
			}
		}
		
		[Export ("updateCapabilityToken:")]
		[CompilerGenerated]
		public virtual void UpdateCapabilityToken (string capabilityToken)
		{
			if (capabilityToken == null)
				throw new ArgumentNullException ("capabilityToken");
			var nscapabilityToken = NSString.CreateNative (capabilityToken);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selUpdateCapabilityToken_Handle, nscapabilityToken);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selUpdateCapabilityToken_Handle, nscapabilityToken);
			}
			NSString.ReleaseNative (nscapabilityToken);
			
		}
		
		[Export ("connect:delegate:")]
		[CompilerGenerated]
		public virtual NSObject Connect (NSDictionary parameters, TCConnectionDelegate d)
		{
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selConnectDelegate_Handle, parameters == null ? IntPtr.Zero : parameters.Handle, d == null ? IntPtr.Zero : d.Handle));
			} else {
				return (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selConnectDelegate_Handle, parameters == null ? IntPtr.Zero : parameters.Handle, d == null ? IntPtr.Zero : d.Handle));
			}
		}
		
		[Export ("disconnectAll")]
		[CompilerGenerated]
		public virtual void DisconnectAll ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDisconnectAllHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDisconnectAllHandle);
			}
		}
		
		[CompilerGenerated]
		public virtual TCDeviceState State {
			[Export ("state")]
			get {
				if (IsDirectBinding) {
					return (TCDeviceState) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selStateHandle);
				} else {
					return (TCDeviceState) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selStateHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Capabilities_var;
		[CompilerGenerated]
		public virtual NSDictionary Capabilities {
			[Export ("capabilities")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCapabilitiesHandle));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCapabilitiesHandle));
				}
				MarkDirty ();
				__mt_Capabilities_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual TCDeviceDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				TCDeviceDelegate ret;
				if (IsDirectBinding) {
					ret = (TCDeviceDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (TCDeviceDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool IncomingSoundEnabled {
			[Export ("incomingSoundEnabled")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIncomingSoundEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIncomingSoundEnabledHandle);
				}
			}
			
			[Export ("setIncomingSoundEnabled:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIncomingSoundEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIncomingSoundEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool OutgoingSoundEnabled {
			[Export ("outgoingSoundEnabled")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selOutgoingSoundEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selOutgoingSoundEnabledHandle);
				}
			}
			
			[Export ("setOutgoingSoundEnabled:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetOutgoingSoundEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetOutgoingSoundEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DisconnectSoundEnabled {
			[Export ("disconnectSoundEnabled")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDisconnectSoundEnabledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selDisconnectSoundEnabledHandle);
				}
			}
			
			[Export ("setDisconnectSoundEnabled:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDisconnectSoundEnabled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDisconnectSoundEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Capabilities_var = null;
				__mt_Delegate_var = null;
			}
		}
	} /* class TCDevice */
}
