using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?g_hamming_dist@lzham@@3PAEA")]
[DemangledName("unsigned char *lzham::g_hamming_dist")]
internal static partial class g_hamming_dist
{
	public unsafe static InlineArray256_SByte* __pointer;

	public unsafe static InlineArray256_SByte Value
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

	unsafe static g_hamming_dist()
	{
		__pointer = unchecked((InlineArray256_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray256_SByte))));
		Value = InlineArrayHelper.Create<InlineArray256_SByte, byte>(new byte[256]
		{
			0, 1, 1, 2, 1, 2, 2, 3, 1, 2,
			2, 3, 2, 3, 3, 4, 1, 2, 2, 3,
			2, 3, 3, 4, 2, 3, 3, 4, 3, 4,
			4, 5, 1, 2, 2, 3, 2, 3, 3, 4,
			2, 3, 3, 4, 3, 4, 4, 5, 2, 3,
			3, 4, 3, 4, 4, 5, 3, 4, 4, 5,
			4, 5, 5, 6, 1, 2, 2, 3, 2, 3,
			3, 4, 2, 3, 3, 4, 3, 4, 4, 5,
			2, 3, 3, 4, 3, 4, 4, 5, 3, 4,
			4, 5, 4, 5, 5, 6, 2, 3, 3, 4,
			3, 4, 4, 5, 3, 4, 4, 5, 4, 5,
			5, 6, 3, 4, 4, 5, 4, 5, 5, 6,
			4, 5, 5, 6, 5, 6, 6, 7, 1, 2,
			2, 3, 2, 3, 3, 4, 2, 3, 3, 4,
			3, 4, 4, 5, 2, 3, 3, 4, 3, 4,
			4, 5, 3, 4, 4, 5, 4, 5, 5, 6,
			2, 3, 3, 4, 3, 4, 4, 5, 3, 4,
			4, 5, 4, 5, 5, 6, 3, 4, 4, 5,
			4, 5, 5, 6, 4, 5, 5, 6, 5, 6,
			6, 7, 2, 3, 3, 4, 3, 4, 4, 5,
			3, 4, 4, 5, 4, 5, 5, 6, 3, 4,
			4, 5, 4, 5, 5, 6, 4, 5, 5, 6,
			5, 6, 6, 7, 3, 4, 4, 5, 4, 5,
			5, 6, 4, 5, 5, 6, 5, 6, 6, 7,
			4, 5, 5, 6, 5, 6, 6, 7, 5, 6,
			6, 7, 6, 7, 7, 8
		});
	}
}
