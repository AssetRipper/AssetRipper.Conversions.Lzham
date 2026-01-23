using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?s_literal_next_state@lzham@@3QBEB")]
[DemangledName("unsigned char const *const lzham::s_literal_next_state")]
internal static partial class s_literal_next_state
{
	[FixedAddressValueType]
	private static InlineArray24_SByte __value;

	public unsafe static InlineArray24_SByte* Pointer => unchecked((InlineArray24_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray24_SByte Value
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

	unsafe static s_literal_next_state()
	{
		Value = InlineArrayHelper.Create<InlineArray24_SByte, byte>(new byte[24]
		{
			0, 0, 0, 0, 1, 2, 3, 4, 5, 6,
			4, 5, 7, 7, 7, 7, 7, 7, 7, 10,
			10, 10, 10, 10
		});
		PointerIndices.Register(Pointer);
	}
}
