using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0FB@CDGPHCAK@E?3?2repos?2AssetRipper?4Conversions@")]
[DemangledName("\"E:\\\\repos\\\\AssetRipper.Conversions\"...")]
[CleanName("String")]
internal static partial class String_v6uahj
{
	[FixedAddressValueType]
	private static InlineArray81_SByte __value;

	public unsafe static InlineArray81_SByte* Pointer => unchecked((InlineArray81_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray81_SByte Value
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

	unsafe static String_v6uahj()
	{
		Value = InlineArrayHelper.Create<InlineArray81_SByte, byte>("E:\\repos\\AssetRipper.Conversions.Lzham\\Original\\lzhamcomp\\lzham_lzcomp_state.cpp\0"u8);
		PointerIndices.Register(Pointer);
	}
}
