using System;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

[MangledName("__CxxFrameHandler3")]
[DemangledName("__CxxFrameHandler3")]
internal static partial class CxxFrameHandler3
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Invoke(ReadOnlySpan<nint> args)
	{
		return IntrinsicFunctions.CxxFrameHandler3(args);
	}
}
