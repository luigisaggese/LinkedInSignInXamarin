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
	[Register("LISDKCallbackHandler", true)]
	public unsafe partial class LISDKCallbackHandler : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("LISDKCallbackHandler");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public LISDKCallbackHandler () : base (NSObjectFlag.Empty)
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
		protected LISDKCallbackHandler (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LISDKCallbackHandler (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("application:openURL:sourceApplication:annotation:")]
		[CompilerGenerated]
		public static bool Application (global::UIKit.UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
		{
			if (application == null)
				throw new ArgumentNullException ("application");
			if (url == null)
				throw new ArgumentNullException ("url");
			if (sourceApplication == null)
				throw new ArgumentNullException ("sourceApplication");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			var nssourceApplication = NSString.CreateNative (sourceApplication);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("application:openURL:sourceApplication:annotation:"), application.Handle, url.Handle, nssourceApplication, annotation.Handle);
			NSString.ReleaseNative (nssourceApplication);
			
			return ret;
		}
		
		[Export ("shouldHandleUrl:")]
		[CompilerGenerated]
		public static bool ShouldHandleUrl (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("shouldHandleUrl:"), url.Handle);
		}
		
	} /* class LISDKCallbackHandler */
}
