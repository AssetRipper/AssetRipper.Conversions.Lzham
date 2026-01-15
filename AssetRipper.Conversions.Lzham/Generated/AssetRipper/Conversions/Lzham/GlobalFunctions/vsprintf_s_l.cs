using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("_vsprintf_s_l")]
[DemangledName("_vsprintf_s_l")]
internal static partial class vsprintf_s_l
{
	public unsafe static int Invoke([MangledName("_Buffer")] void* Buffer, [MangledName("_BufferCount")] long BufferCount, [MangledName("_Format")] void* Format, [MangledName("_Locale")] void* Locale, [MangledName("_ArgList")] void* ArgList)
	{
		int num = stdio_common_vsprintf_s.Invoke(*unchecked((long*)local_stdio_printf_options.Invoke()), Buffer, BufferCount, Format, Locale, ArgList);
		return (num >= 0) ? num : (-1);
	}
}
