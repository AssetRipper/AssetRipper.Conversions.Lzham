using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

[MangledName("__acrt_iob_func")]
[DemangledName("__acrt_iob_func")]
internal static partial class acrt_iob_func
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void* Invoke(int identifier)
	{
		return IntrinsicFunctions.GetSystemStream(identifier);
	}
}
