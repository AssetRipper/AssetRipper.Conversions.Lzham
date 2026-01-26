using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?g_freq@lzham_timer@lzham@@0_KA")]
[DemangledName("private: static unsigned __int64 lzham::lzham_timer::g_freq")]
internal static partial class g_freq
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

	unsafe static g_freq()
	{
		PointerIndices.Register(Pointer);
	}
}
