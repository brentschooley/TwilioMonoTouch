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
	[Register("TCConnection", true)]
	public unsafe partial class TCConnection : NSObject {
		[CompilerGenerated]
		const string selState = "state";
		static readonly IntPtr selStateHandle = Selector.GetHandle ("state");
		[CompilerGenerated]
		const string selIsIncoming = "isIncoming";
		static readonly IntPtr selIsIncomingHandle = Selector.GetHandle ("isIncoming");
		[CompilerGenerated]
		const string selParameters = "parameters";
		static readonly IntPtr selParametersHandle = Selector.GetHandle ("parameters");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selIsMuted = "isMuted";
		static readonly IntPtr selIsMutedHandle = Selector.GetHandle ("isMuted");
		[CompilerGenerated]
		const string selSetMuted_ = "setMuted:";
		static readonly IntPtr selSetMuted_Handle = Selector.GetHandle ("setMuted:");
		[CompilerGenerated]
		const string selAccept = "accept";
		static readonly IntPtr selAcceptHandle = Selector.GetHandle ("accept");
		[CompilerGenerated]
		const string selIgnore = "ignore";
		static readonly IntPtr selIgnoreHandle = Selector.GetHandle ("ignore");
		[CompilerGenerated]
		const string selReject = "reject";
		static readonly IntPtr selRejectHandle = Selector.GetHandle ("reject");
		[CompilerGenerated]
		const string selDisconnect = "disconnect";
		static readonly IntPtr selDisconnectHandle = Selector.GetHandle ("disconnect");
		[CompilerGenerated]
		const string selSendDigits_ = "sendDigits:";
		static readonly IntPtr selSendDigits_Handle = Selector.GetHandle ("sendDigits:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TCConnection");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TCConnection () : base (NSObjectFlag.Empty)
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
		public TCConnection (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public TCConnection (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCConnection (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("accept")]
		[CompilerGenerated]
		public virtual void Accept ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selAcceptHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selAcceptHandle);
			}
		}
		
		[Export ("ignore")]
		[CompilerGenerated]
		public virtual void Ignore ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selIgnoreHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selIgnoreHandle);
			}
		}
		
		[Export ("reject")]
		[CompilerGenerated]
		public virtual void Reject ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRejectHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRejectHandle);
			}
		}
		
		[Export ("disconnect")]
		[CompilerGenerated]
		public virtual void Disconnect ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDisconnectHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDisconnectHandle);
			}
		}
		
		[Export ("sendDigits:")]
		[CompilerGenerated]
		public virtual void SendDigits (string digits)
		{
			if (digits == null)
				throw new ArgumentNullException ("digits");
			var nsdigits = NSString.CreateNative (digits);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSendDigits_Handle, nsdigits);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSendDigits_Handle, nsdigits);
			}
			NSString.ReleaseNative (nsdigits);
			
		}
		
		[CompilerGenerated]
		public virtual TCConnectionState State {
			[Export ("state")]
			get {
				if (IsDirectBinding) {
					return (TCConnectionState) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selStateHandle);
				} else {
					return (TCConnectionState) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selStateHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool Incoming {
			[Export ("isIncoming")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsIncomingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsIncomingHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Parameters_var;
		[CompilerGenerated]
		public virtual NSDictionary Parameters {
			[Export ("parameters")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParametersHandle));
				} else {
					ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParametersHandle));
				}
				MarkDirty ();
				__mt_Parameters_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual TCConnectionDelegate WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				TCConnectionDelegate ret;
				if (IsDirectBinding) {
					ret = (TCConnectionDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (TCConnectionDelegate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
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
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool Muted {
			[Export ("isMuted")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsMutedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsMutedHandle);
				}
			}
			
			[Export ("setMuted:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetMuted_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetMuted_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Parameters_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class TCConnection */
}
