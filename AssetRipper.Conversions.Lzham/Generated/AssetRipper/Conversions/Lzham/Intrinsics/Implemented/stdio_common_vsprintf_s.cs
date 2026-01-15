using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

[MangledName("__stdio_common_vsprintf_s")]
[DemangledName("__stdio_common_vsprintf_s")]
internal static partial class stdio_common_vsprintf_s
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static int Invoke(long options, void* buffer, long bufferLength, void* format, void* locale, void* argList)
	{
		return IntrinsicFunctions.__stdio_common_vsprintf_s(options, buffer, bufferLength, format, locale, argList);
	}
}
