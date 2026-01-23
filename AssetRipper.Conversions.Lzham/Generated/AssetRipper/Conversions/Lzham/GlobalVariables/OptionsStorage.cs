using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?_OptionsStorage@?1??__local_stdio_printf_options@@9@4_KA")]
[DemangledName("unsigned __int64 `extern \"C\" __local_stdio_printf_options'::`2'::_OptionsStorage")]
internal static partial class OptionsStorage
{
	[FixedAddressValueType]
	private static long __value;

	public unsafe static long* Pointer => unchecked((long*)Unsafe.AsPointer(ref __value));

	public static long Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static OptionsStorage()
	{
		Value = 0L;
		PointerIndices.Register(Pointer);
	}
}
