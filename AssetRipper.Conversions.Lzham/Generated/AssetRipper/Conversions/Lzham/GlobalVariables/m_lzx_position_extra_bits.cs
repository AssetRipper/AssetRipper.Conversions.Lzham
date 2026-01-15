using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?m_lzx_position_extra_bits@CLZDecompBase@lzham@@2PAEA")]
[DemangledName("public: static unsigned char *lzham::CLZDecompBase::m_lzx_position_extra_bits")]
internal static partial class m_lzx_position_extra_bits
{
	public unsafe static InlineArray128_SByte* __pointer;

	public unsafe static InlineArray128_SByte Value
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

	unsafe static m_lzx_position_extra_bits()
	{
		__pointer = unchecked((InlineArray128_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray128_SByte))));
		Value = InlineArrayHelper.Create<InlineArray128_SByte, byte>(new byte[128]
		{
			0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
			4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
			9, 9, 10, 10, 11, 11, 12, 12, 13, 13,
			14, 14, 15, 15, 16, 16, 17, 17, 18, 18,
			19, 19, 20, 20, 21, 21, 22, 22, 23, 23,
			24, 24, 25, 25, 25, 25, 25, 25, 25, 25,
			25, 25, 25, 25, 25, 25, 25, 25, 25, 25,
			25, 25, 25, 25, 25, 25, 25, 25, 25, 25,
			25, 25, 25, 25, 25, 25, 25, 25, 25, 25,
			25, 25, 25, 25, 25, 25, 25, 25, 25, 25,
			25, 25, 25, 25, 25, 25, 25, 25, 25, 25,
			25, 25, 25, 25, 25, 25, 25, 25, 25, 25,
			25, 25, 25, 25, 25, 25, 25, 25
		});
	}
}
