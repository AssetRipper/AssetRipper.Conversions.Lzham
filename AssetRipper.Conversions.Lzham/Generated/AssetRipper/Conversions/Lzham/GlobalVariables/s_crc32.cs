using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?s_crc32@lzham@@3QBIB")]
[DemangledName("unsigned int const *const lzham::s_crc32")]
internal static partial class s_crc32
{
	public unsafe static InlineArray16_Int32* __pointer;

	public unsafe static InlineArray16_Int32 Value
	{
		get
		{
			return *__pointer;
		}
		set
		{
			*__pointer = value;
		}
	}

	unsafe static s_crc32()
	{
		__pointer = unchecked((InlineArray16_Int32*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray16_Int32))));
		Value = InlineArrayHelper.Create<InlineArray16_Int32, int>(new int[16]
		{
			0, 498536548, 997073096, 651767980, 1994146192, 1802195444, 1303535960, 1342533948, -306674912, -267414716,
			-690576408, -882789492, -1687895376, -2032938284, -1609899400, -1111625188
		});
	}
}
