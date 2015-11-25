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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DAuthSuccessBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAuthSuccessBlock {
			static internal readonly DAuthSuccessBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAuthSuccessBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::LinkedIn.SignIn.AuthSuccessBlock) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg0));
			}
		} /* class SDAuthSuccessBlock */
		
		internal class NIDAuthSuccessBlock {
			IntPtr blockPtr;
			DAuthSuccessBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAuthSuccessBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAuthSuccessBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAuthSuccessBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::LinkedIn.SignIn.AuthSuccessBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::LinkedIn.SignIn.AuthSuccessBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDAuthSuccessBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (string arg0)
			{
				var nsarg0 = NSString.CreateNative (arg0);
				
				invoker (blockPtr, nsarg0);
				NSString.ReleaseNative (nsarg0);
				
			}
		} /* class NIDAuthSuccessBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DAuthErrorBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAuthErrorBlock {
			static internal readonly DAuthErrorBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAuthErrorBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::LinkedIn.SignIn.AuthErrorBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSError> (arg0));
			}
		} /* class SDAuthErrorBlock */
		
		internal class NIDAuthErrorBlock {
			IntPtr blockPtr;
			DAuthErrorBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAuthErrorBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAuthErrorBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAuthErrorBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::LinkedIn.SignIn.AuthErrorBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::LinkedIn.SignIn.AuthErrorBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDAuthErrorBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDAuthErrorBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V0 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::LinkedIn.SignIn.ApiResponse>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<LinkedIn.SignIn.ApiResponse> (obj));
			}
		} /* class SDActionArity1V0 */
		
		internal class NIDActionArity1V0 {
			IntPtr blockPtr;
			DActionArity1V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::LinkedIn.SignIn.ApiResponse> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::LinkedIn.SignIn.ApiResponse>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::LinkedIn.SignIn.ApiResponse obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V1 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V1 {
			static internal readonly DActionArity1V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V1))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::LinkedIn.SignIn.ApiError>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<LinkedIn.SignIn.ApiError> (obj));
			}
		} /* class SDActionArity1V1 */
		
		internal class NIDActionArity1V1 {
			IntPtr blockPtr;
			DActionArity1V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::LinkedIn.SignIn.ApiError> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::LinkedIn.SignIn.ApiError>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::LinkedIn.SignIn.ApiError obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V1 */
	}
}
