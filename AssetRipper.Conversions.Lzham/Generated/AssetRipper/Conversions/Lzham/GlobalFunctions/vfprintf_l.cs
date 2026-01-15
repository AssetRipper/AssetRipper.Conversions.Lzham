using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("_vfprintf_l")]
[DemangledName("_vfprintf_l")]
internal static partial class vfprintf_l
{
	public unsafe static int Invoke([MangledName("_Stream")] void* Stream, [MangledName("_Format")] void* Format, [MangledName("_Locale")] void* Locale, [MangledName("_ArgList")] void* ArgList)
	{
		return stdio_common_vfprintf.Invoke(*unchecked((long*)local_stdio_printf_options.Invoke()), Stream, Format, Locale, ArgList);
	}
}
