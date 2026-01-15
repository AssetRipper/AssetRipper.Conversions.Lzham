using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

[MangledName("__stdio_common_vfprintf")]
[DemangledName("__stdio_common_vfprintf")]
internal static partial class stdio_common_vfprintf
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static int Invoke(long options, void* stream, void* format, void* locale, void* argList)
	{
		return IntrinsicFunctions.__stdio_common_vfprintf(options, stream, format, locale, argList);
	}
}
