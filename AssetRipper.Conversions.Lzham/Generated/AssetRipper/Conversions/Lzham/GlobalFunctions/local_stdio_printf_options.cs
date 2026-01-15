using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("__local_stdio_printf_options")]
[DemangledName("__local_stdio_printf_options")]
internal static partial class local_stdio_printf_options
{
	public unsafe static void* Invoke()
	{
		return OptionsStorage.__pointer;
	}
}
