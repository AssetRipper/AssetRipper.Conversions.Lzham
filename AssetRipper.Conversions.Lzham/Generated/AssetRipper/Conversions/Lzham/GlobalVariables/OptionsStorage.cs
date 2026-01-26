using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?_OptionsStorage@?1??__local_stdio_printf_options@@9@4_KA")]
[DemangledName("unsigned __int64 `extern \"C\" __local_stdio_printf_options'::`2'::_OptionsStorage")]
internal static partial class OptionsStorage
{
	private partial struct __WrapperType
	{
		public long __value;
	}

	[FixedAddressValueType]
	private static __WrapperType __value;

	public unsafe static long* Pointer => unchecked((long*)Unsafe.AsPointer(ref __value));

	public static long Value
	{
		get
		{
			return __value.__value;
		}
		set
		{
			__value.__value = value;
		}
	}

	unsafe static OptionsStorage()
	{
		PointerIndices.Register(Pointer);
	}
}
