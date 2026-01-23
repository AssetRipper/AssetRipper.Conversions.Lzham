using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BO@CHJDIDGP@match_len?5?$DM?$DN?5actual_match_len?$AA@")]
[DemangledName("\"match_len <= actual_match_len\"")]
[CleanName("String")]
internal static partial class String_vkn2me
{
	[FixedAddressValueType]
	private static InlineArray30_SByte __value;

	public unsafe static InlineArray30_SByte* Pointer => unchecked((InlineArray30_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray30_SByte Value
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

	unsafe static String_vkn2me()
	{
		Value = InlineArrayHelper.Create<InlineArray30_SByte, byte>("match_len <= actual_match_len\0"u8);
		PointerIndices.Register(Pointer);
	}
}
