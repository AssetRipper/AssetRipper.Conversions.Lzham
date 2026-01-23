using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?g_num_lzx_position_slots@lzham@@3QBEB")]
[DemangledName("unsigned char const *const lzham::g_num_lzx_position_slots")]
internal static partial class g_num_lzx_position_slots
{
	[FixedAddressValueType]
	private static InlineArray15_SByte __value;

	public unsafe static InlineArray15_SByte* Pointer => unchecked((InlineArray15_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray15_SByte Value
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

	unsafe static g_num_lzx_position_slots()
	{
		Value = InlineArrayHelper.Create<InlineArray15_SByte, byte>(new byte[15]
		{
			30, 32, 34, 36, 38, 40, 42, 44, 46, 48,
			50, 52, 54, 58, 66
		});
		PointerIndices.Register(Pointer);
	}
}
