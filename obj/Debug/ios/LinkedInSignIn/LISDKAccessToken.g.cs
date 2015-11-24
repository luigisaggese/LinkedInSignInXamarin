//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace LinkedIn.SignIn {
	[Register("LISDKAccessToken", true)]
	public unsafe partial class LISDKAccessToken : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("LISDKAccessToken");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public LISDKAccessToken () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LISDKAccessToken (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LISDKAccessToken (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("LISDKAccessTokenWithSerializedString:")]
		[CompilerGenerated]
		public static LISDKAccessToken LISDKAccessTokenWithSerializedString (string serString)
		{
			if (serString == null)
				throw new ArgumentNullException ("serString");
			var nsserString = NSString.CreateNative (serString);
			
			LISDKAccessToken ret;
			ret =  Runtime.GetNSObject<LISDKAccessToken> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("LISDKAccessTokenWithSerializedString:"), nsserString));
			NSString.ReleaseNative (nsserString);
			
			return ret;
		}
		
		[Export ("LISDKAccessTokenWithValue:expiresOnMillis:")]
		[CompilerGenerated]
		public static LISDKAccessToken LISDKAccessTokenWithValue (string value, global::System.Int64 expiresOnMillis)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			LISDKAccessToken ret;
			ret =  Runtime.GetNSObject<LISDKAccessToken> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_Int64 (class_ptr, Selector.GetHandle ("LISDKAccessTokenWithValue:expiresOnMillis:"), nsvalue, expiresOnMillis));
			NSString.ReleaseNative (nsvalue);
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual string AccessTokenValue {
			[Export ("accessTokenValue")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessTokenValue")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessTokenValue")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Expiration_var;
		[CompilerGenerated]
		public virtual NSDate Expiration {
			[Export ("expiration")]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("expiration")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("expiration")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Expiration_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SerializedString {
			[Export ("serializedString")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("serializedString")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("serializedString")));
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Expiration_var = null;
			}
		}
	} /* class LISDKAccessToken */
}
