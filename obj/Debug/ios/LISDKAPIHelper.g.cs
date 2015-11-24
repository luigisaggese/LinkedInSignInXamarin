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

[Register("LISDKAPIHelper", true)]
public unsafe partial class LISDKAPIHelper : NSObject {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("LISDKAPIHelper");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public LISDKAPIHelper () : base (NSObjectFlag.Empty)
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
		protected LISDKAPIHelper (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LISDKAPIHelper (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[Export ("apiRequest:method:body:success:error:")]
	[CompilerGenerated]
	public unsafe virtual void ApiRequest (string url, string method, NSData body, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::LISDKAPIResponse> successCompletion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<global::LISDKAPIError> errorCompletion)
	{
		if (url == null)
			throw new ArgumentNullException ("url");
		if (method == null)
			throw new ArgumentNullException ("method");
		if (body == null)
			throw new ArgumentNullException ("body");
		if (successCompletion == null)
			throw new ArgumentNullException ("successCompletion");
		if (errorCompletion == null)
			throw new ArgumentNullException ("errorCompletion");
		var nsurl = NSString.CreateNative (url);
		var nsmethod = NSString.CreateNative (method);
		BlockLiteral *block_ptr_successCompletion;
		BlockLiteral block_successCompletion;
		block_successCompletion = new BlockLiteral ();
		block_ptr_successCompletion = &block_successCompletion;
		block_successCompletion.SetupBlock (Trampolines.SDActionArity1V0.Handler, successCompletion);
		BlockLiteral *block_ptr_errorCompletion;
		BlockLiteral block_errorCompletion;
		block_errorCompletion = new BlockLiteral ();
		block_ptr_errorCompletion = &block_errorCompletion;
		block_errorCompletion.SetupBlock (Trampolines.SDActionArity1V1.Handler, errorCompletion);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("apiRequest:method:body:success:error:"), nsurl, nsmethod, body.Handle, (IntPtr) block_ptr_successCompletion, (IntPtr) block_ptr_errorCompletion);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("apiRequest:method:body:success:error:"), nsurl, nsmethod, body.Handle, (IntPtr) block_ptr_successCompletion, (IntPtr) block_ptr_errorCompletion);
		}
		NSString.ReleaseNative (nsurl);
		NSString.ReleaseNative (nsmethod);
		block_ptr_successCompletion->CleanupBlock ();
		block_ptr_errorCompletion->CleanupBlock ();
		
	}
	
	[Export ("cancelCalls")]
	[CompilerGenerated]
	public virtual void CancelCalls ()
	{
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelCalls"));
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelCalls"));
		}
	}
	
	[Export ("deleteRequest:success:error:")]
	[CompilerGenerated]
	public unsafe virtual void DeleteRequest (string url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::LISDKAPIResponse> successCompletion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<global::LISDKAPIError> errorCompletion)
	{
		if (url == null)
			throw new ArgumentNullException ("url");
		if (successCompletion == null)
			throw new ArgumentNullException ("successCompletion");
		if (errorCompletion == null)
			throw new ArgumentNullException ("errorCompletion");
		var nsurl = NSString.CreateNative (url);
		BlockLiteral *block_ptr_successCompletion;
		BlockLiteral block_successCompletion;
		block_successCompletion = new BlockLiteral ();
		block_ptr_successCompletion = &block_successCompletion;
		block_successCompletion.SetupBlock (Trampolines.SDActionArity1V0.Handler, successCompletion);
		BlockLiteral *block_ptr_errorCompletion;
		BlockLiteral block_errorCompletion;
		block_errorCompletion = new BlockLiteral ();
		block_ptr_errorCompletion = &block_errorCompletion;
		block_errorCompletion.SetupBlock (Trampolines.SDActionArity1V1.Handler, errorCompletion);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("deleteRequest:success:error:"), nsurl, (IntPtr) block_ptr_successCompletion, (IntPtr) block_ptr_errorCompletion);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("deleteRequest:success:error:"), nsurl, (IntPtr) block_ptr_successCompletion, (IntPtr) block_ptr_errorCompletion);
		}
		NSString.ReleaseNative (nsurl);
		block_ptr_successCompletion->CleanupBlock ();
		block_ptr_errorCompletion->CleanupBlock ();
		
	}
	
	[Export ("getRequest:success:error:")]
	[CompilerGenerated]
	public unsafe virtual void GetRequest (string url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::LISDKAPIResponse> success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<global::LISDKAPIError> error)
	{
		if (url == null)
			throw new ArgumentNullException ("url");
		if (success == null)
			throw new ArgumentNullException ("success");
		if (error == null)
			throw new ArgumentNullException ("error");
		var nsurl = NSString.CreateNative (url);
		BlockLiteral *block_ptr_success;
		BlockLiteral block_success;
		block_success = new BlockLiteral ();
		block_ptr_success = &block_success;
		block_success.SetupBlock (Trampolines.SDActionArity1V0.Handler, success);
		BlockLiteral *block_ptr_error;
		BlockLiteral block_error;
		block_error = new BlockLiteral ();
		block_ptr_error = &block_error;
		block_error.SetupBlock (Trampolines.SDActionArity1V1.Handler, error);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("getRequest:success:error:"), nsurl, (IntPtr) block_ptr_success, (IntPtr) block_ptr_error);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("getRequest:success:error:"), nsurl, (IntPtr) block_ptr_success, (IntPtr) block_ptr_error);
		}
		NSString.ReleaseNative (nsurl);
		block_ptr_success->CleanupBlock ();
		block_ptr_error->CleanupBlock ();
		
	}
	
	[Export ("postRequest:body:success:error:")]
	[CompilerGenerated]
	public unsafe virtual void PostRequest (string url, NSData body, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::LISDKAPIResponse> successCompletion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<global::LISDKAPIError> errorCompletion)
	{
		if (url == null)
			throw new ArgumentNullException ("url");
		if (body == null)
			throw new ArgumentNullException ("body");
		if (successCompletion == null)
			throw new ArgumentNullException ("successCompletion");
		if (errorCompletion == null)
			throw new ArgumentNullException ("errorCompletion");
		var nsurl = NSString.CreateNative (url);
		BlockLiteral *block_ptr_successCompletion;
		BlockLiteral block_successCompletion;
		block_successCompletion = new BlockLiteral ();
		block_ptr_successCompletion = &block_successCompletion;
		block_successCompletion.SetupBlock (Trampolines.SDActionArity1V0.Handler, successCompletion);
		BlockLiteral *block_ptr_errorCompletion;
		BlockLiteral block_errorCompletion;
		block_errorCompletion = new BlockLiteral ();
		block_ptr_errorCompletion = &block_errorCompletion;
		block_errorCompletion.SetupBlock (Trampolines.SDActionArity1V1.Handler, errorCompletion);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("postRequest:body:success:error:"), nsurl, body.Handle, (IntPtr) block_ptr_successCompletion, (IntPtr) block_ptr_errorCompletion);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("postRequest:body:success:error:"), nsurl, body.Handle, (IntPtr) block_ptr_successCompletion, (IntPtr) block_ptr_errorCompletion);
		}
		NSString.ReleaseNative (nsurl);
		block_ptr_successCompletion->CleanupBlock ();
		block_ptr_errorCompletion->CleanupBlock ();
		
	}
	
	[Export ("postRequest:stringBody:success:error:")]
	[CompilerGenerated]
	public unsafe virtual void PostRequest (string url, string stringBody, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::LISDKAPIResponse> successCompletion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<global::LISDKAPIError> errorCompletion)
	{
		if (url == null)
			throw new ArgumentNullException ("url");
		if (stringBody == null)
			throw new ArgumentNullException ("stringBody");
		if (successCompletion == null)
			throw new ArgumentNullException ("successCompletion");
		if (errorCompletion == null)
			throw new ArgumentNullException ("errorCompletion");
		var nsurl = NSString.CreateNative (url);
		var nsstringBody = NSString.CreateNative (stringBody);
		BlockLiteral *block_ptr_successCompletion;
		BlockLiteral block_successCompletion;
		block_successCompletion = new BlockLiteral ();
		block_ptr_successCompletion = &block_successCompletion;
		block_successCompletion.SetupBlock (Trampolines.SDActionArity1V0.Handler, successCompletion);
		BlockLiteral *block_ptr_errorCompletion;
		BlockLiteral block_errorCompletion;
		block_errorCompletion = new BlockLiteral ();
		block_ptr_errorCompletion = &block_errorCompletion;
		block_errorCompletion.SetupBlock (Trampolines.SDActionArity1V1.Handler, errorCompletion);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("postRequest:stringBody:success:error:"), nsurl, nsstringBody, (IntPtr) block_ptr_successCompletion, (IntPtr) block_ptr_errorCompletion);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("postRequest:stringBody:success:error:"), nsurl, nsstringBody, (IntPtr) block_ptr_successCompletion, (IntPtr) block_ptr_errorCompletion);
		}
		NSString.ReleaseNative (nsurl);
		NSString.ReleaseNative (nsstringBody);
		block_ptr_successCompletion->CleanupBlock ();
		block_ptr_errorCompletion->CleanupBlock ();
		
	}
	
	[Export ("putRequest:body:success:error:")]
	[CompilerGenerated]
	public unsafe virtual void PutRequest (string url, NSData body, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::LISDKAPIResponse> successCompletion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<global::LISDKAPIError> errorCompletion)
	{
		if (url == null)
			throw new ArgumentNullException ("url");
		if (body == null)
			throw new ArgumentNullException ("body");
		if (successCompletion == null)
			throw new ArgumentNullException ("successCompletion");
		if (errorCompletion == null)
			throw new ArgumentNullException ("errorCompletion");
		var nsurl = NSString.CreateNative (url);
		BlockLiteral *block_ptr_successCompletion;
		BlockLiteral block_successCompletion;
		block_successCompletion = new BlockLiteral ();
		block_ptr_successCompletion = &block_successCompletion;
		block_successCompletion.SetupBlock (Trampolines.SDActionArity1V0.Handler, successCompletion);
		BlockLiteral *block_ptr_errorCompletion;
		BlockLiteral block_errorCompletion;
		block_errorCompletion = new BlockLiteral ();
		block_ptr_errorCompletion = &block_errorCompletion;
		block_errorCompletion.SetupBlock (Trampolines.SDActionArity1V1.Handler, errorCompletion);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("putRequest:body:success:error:"), nsurl, body.Handle, (IntPtr) block_ptr_successCompletion, (IntPtr) block_ptr_errorCompletion);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("putRequest:body:success:error:"), nsurl, body.Handle, (IntPtr) block_ptr_successCompletion, (IntPtr) block_ptr_errorCompletion);
		}
		NSString.ReleaseNative (nsurl);
		block_ptr_successCompletion->CleanupBlock ();
		block_ptr_errorCompletion->CleanupBlock ();
		
	}
	
	[Export ("putRequest:stringBody:success:error:")]
	[CompilerGenerated]
	public unsafe virtual void PutRequest (string url, string stringBody, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::LISDKAPIResponse> successCompletion, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<global::LISDKAPIError> errorCompletion)
	{
		if (url == null)
			throw new ArgumentNullException ("url");
		if (stringBody == null)
			throw new ArgumentNullException ("stringBody");
		if (successCompletion == null)
			throw new ArgumentNullException ("successCompletion");
		if (errorCompletion == null)
			throw new ArgumentNullException ("errorCompletion");
		var nsurl = NSString.CreateNative (url);
		var nsstringBody = NSString.CreateNative (stringBody);
		BlockLiteral *block_ptr_successCompletion;
		BlockLiteral block_successCompletion;
		block_successCompletion = new BlockLiteral ();
		block_ptr_successCompletion = &block_successCompletion;
		block_successCompletion.SetupBlock (Trampolines.SDActionArity1V0.Handler, successCompletion);
		BlockLiteral *block_ptr_errorCompletion;
		BlockLiteral block_errorCompletion;
		block_errorCompletion = new BlockLiteral ();
		block_ptr_errorCompletion = &block_errorCompletion;
		block_errorCompletion.SetupBlock (Trampolines.SDActionArity1V1.Handler, errorCompletion);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("putRequest:stringBody:success:error:"), nsurl, nsstringBody, (IntPtr) block_ptr_successCompletion, (IntPtr) block_ptr_errorCompletion);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("putRequest:stringBody:success:error:"), nsurl, nsstringBody, (IntPtr) block_ptr_successCompletion, (IntPtr) block_ptr_errorCompletion);
		}
		NSString.ReleaseNative (nsurl);
		NSString.ReleaseNative (nsstringBody);
		block_ptr_successCompletion->CleanupBlock ();
		block_ptr_errorCompletion->CleanupBlock ();
		
	}
	
	[Export ("sharedInstance")]
	[CompilerGenerated]
	public static global::LISDKAPIHelper SharedInstance ()
	{
		return  Runtime.GetNSObject<global::LISDKAPIHelper> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
	}
	
} /* class LISDKAPIHelper */
