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

[Register("LISDKSessionManager", true)]
public unsafe partial class LISDKSessionManager : NSObject {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("LISDKSessionManager");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public LISDKSessionManager () : base (NSObjectFlag.Empty)
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
		protected LISDKSessionManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LISDKSessionManager (IntPtr handle) : base (handle)
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
	
	[Export ("clearSession")]
	[CompilerGenerated]
	public static void ClearSession ()
	{
		global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("clearSession"));
	}
	
	[Export ("createSessionWithAccessToken:")]
	[CompilerGenerated]
	public static void CreateSessionWithAccessToken (global::LISDKAccessToken accessToken)
	{
		if (accessToken == null)
			throw new ArgumentNullException ("accessToken");
		global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("createSessionWithAccessToken:"), accessToken.Handle);
	}
	
	[Export ("createSessionWithAuth:state:showGoToAppStoreDialog:successBlock:errorBlock:")]
	[CompilerGenerated]
	public unsafe static void CreateSessionWithAuth (NSObject[] permissions, string state, bool showDialog, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAuthSuccessBlock))]global::AuthSuccessBlock successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAuthErrorBlock))]global::AuthErrorBlock erroBlock)
	{
		if (permissions == null)
			throw new ArgumentNullException ("permissions");
		if (successBlock == null)
			throw new ArgumentNullException ("successBlock");
		if (erroBlock == null)
			throw new ArgumentNullException ("erroBlock");
		var nsa_permissions = NSArray.FromNSObjects (permissions);
		var nsstate = NSString.CreateNative (state);
		BlockLiteral *block_ptr_successBlock;
		BlockLiteral block_successBlock;
		block_successBlock = new BlockLiteral ();
		block_ptr_successBlock = &block_successBlock;
		block_successBlock.SetupBlock (Trampolines.SDAuthSuccessBlock.Handler, successBlock);
		BlockLiteral *block_ptr_erroBlock;
		BlockLiteral block_erroBlock;
		block_erroBlock = new BlockLiteral ();
		block_ptr_erroBlock = &block_erroBlock;
		block_erroBlock.SetupBlock (Trampolines.SDAuthErrorBlock.Handler, erroBlock);
		
		global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("createSessionWithAuth:state:showGoToAppStoreDialog:successBlock:errorBlock:"), nsa_permissions.Handle, nsstate, showDialog, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_erroBlock);
		nsa_permissions.Dispose ();
		NSString.ReleaseNative (nsstate);
		block_ptr_successBlock->CleanupBlock ();
		block_ptr_erroBlock->CleanupBlock ();
		
	}
	
	[Export ("sharedInstance")]
	[CompilerGenerated]
	public static global::LISDKSessionManager SharedInstance ()
	{
		return  Runtime.GetNSObject<global::LISDKSessionManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
	}
	
	[Export ("shouldHandleUrl:")]
	[CompilerGenerated]
	public static bool ShouldHandleUrl (NSUrl url)
	{
		if (url == null)
			throw new ArgumentNullException ("url");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("shouldHandleUrl:"), url.Handle);
	}
	
	[CompilerGenerated]
	public static bool HasValidSession {
		[Export ("hasValidSession")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("hasValidSession"));
		}
		
	}
	
	[CompilerGenerated]
	object __mt_Session_var;
	[CompilerGenerated]
	public virtual global::LISDKSession Session {
		[Export ("session")]
		get {
			global::LISDKSession ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::LISDKSession> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("session")));
			} else {
				ret =  Runtime.GetNSObject<global::LISDKSession> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("session")));
			}
			if (!IsNewRefcountEnabled ())
				__mt_Session_var = ret;
			return ret;
		}
		
	}
	
	[CompilerGenerated]
	protected override void Dispose (bool disposing)
	{
		base.Dispose (disposing);
		if (Handle == IntPtr.Zero) {
			__mt_Session_var = null;
		}
	}
} /* class LISDKSessionManager */
