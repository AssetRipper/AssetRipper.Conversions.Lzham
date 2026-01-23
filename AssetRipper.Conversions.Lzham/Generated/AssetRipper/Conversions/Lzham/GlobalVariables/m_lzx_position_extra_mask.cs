using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?m_lzx_position_extra_mask@CLZDecompBase@lzham@@2PAIA")]
[DemangledName("public: static unsigned int *lzham::CLZDecompBase::m_lzx_position_extra_mask")]
internal static partial class m_lzx_position_extra_mask
{
	[FixedAddressValueType]
	private static InlineArray128_Int32 __value;

	public unsafe static InlineArray128_Int32* Pointer => unchecked((InlineArray128_Int32*)Unsafe.AsPointer(ref __value));

	public static InlineArray128_Int32 Value
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

	unsafe static m_lzx_position_extra_mask()
	{
		Value = InlineArrayHelper.Create<InlineArray128_Int32, int>(new int[128]
		{
			0, 0, 0, 0, 1, 1, 3, 3, 7, 7,
			15, 15, 31, 31, 63, 63, 127, 127, 255, 255,
			511, 511, 1023, 1023, 2047, 2047, 4095, 4095, 8191, 8191,
			16383, 16383, 32767, 32767, 65535, 65535, 131071, 131071, 262143, 262143,
			524287, 524287, 1048575, 1048575, 2097151, 2097151, 4194303, 4194303, 8388607, 8388607,
			16777215, 16777215, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431,
			33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431,
			33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431,
			33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431,
			33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431,
			33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431,
			33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431,
			33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431, 33554431
		});
		PointerIndices.Register(Pointer);
	}
}
