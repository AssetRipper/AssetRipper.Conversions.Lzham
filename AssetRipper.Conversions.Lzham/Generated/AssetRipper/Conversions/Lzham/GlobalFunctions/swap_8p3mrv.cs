using System;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$swap@PEAE@utils@lzham@@YAXAEAPEAE0@Z")]
[DemangledName("void __cdecl lzham::utils::swap<unsigned char *>(unsigned char *&, unsigned char *&)")]
[CleanName("swap")]
internal static partial class swap_8p3mrv
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned char *&")] void* l, [NativeType("unsigned char *&")] void* r)
	{
		unchecked
		{
			IntPtr intPtr = *(IntPtr*)l;
			*(IntPtr*)l = *(IntPtr*)r;
			*(IntPtr*)r = intPtr;
		}
	}
}
