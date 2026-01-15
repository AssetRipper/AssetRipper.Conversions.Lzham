using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?g_num_lzx_position_slots@lzham@@3QBEB")]
[DemangledName("unsigned char const *const lzham::g_num_lzx_position_slots")]
internal static partial class g_num_lzx_position_slots
{
	public unsafe static InlineArray15_SByte* __pointer;

	public unsafe static InlineArray15_SByte Value
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

	unsafe static g_num_lzx_position_slots()
	{
		__pointer = unchecked((InlineArray15_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray15_SByte))));
		Value = InlineArrayHelper.Create<InlineArray15_SByte, byte>(new byte[15]
		{
			30, 32, 34, 36, 38, 40, 42, 44, 46, 48,
			50, 52, 54, 58, 66
		});
	}
}
