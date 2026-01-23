using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?g_init_ticks@lzham_timer@lzham@@0_KA")]
[DemangledName("private: static unsigned __int64 lzham::lzham_timer::g_init_ticks")]
internal static partial class g_init_ticks
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

	unsafe static g_init_ticks()
	{
		Value = 0L;
		PointerIndices.Register(Pointer);
	}
}
