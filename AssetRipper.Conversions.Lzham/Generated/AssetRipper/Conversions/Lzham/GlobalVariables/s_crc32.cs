using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?s_crc32@lzham@@3QBIB")]
[DemangledName("unsigned int const *const lzham::s_crc32")]
internal static partial class s_crc32
{
	[FixedAddressValueType]
	private static InlineArray16_Int32 __value;

	public unsafe static InlineArray16_Int32* Pointer => unchecked((InlineArray16_Int32*)Unsafe.AsPointer(ref __value));

	public static InlineArray16_Int32 Value
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

	unsafe static s_crc32()
	{
		Value = InlineArrayHelper.Create<InlineArray16_Int32, int>(new int[16]
		{
			0, 498536548, 997073096, 651767980, 1994146192, 1802195444, 1303535960, 1342533948, -306674912, -267414716,
			-690576408, -882789492, -1687895376, -2032938284, -1609899400, -1111625188
		});
		PointerIndices.Register(Pointer);
	}
}
