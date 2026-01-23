using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("??_C@_0BK@OKLBJHCF@find_all_matches_callback?$AA@")]
[DemangledName("\"find_all_matches_callback\"")]
[CleanName("String")]
internal static partial class String_d9apgb
{
	[FixedAddressValueType]
	private static InlineArray26_SByte __value;

	public unsafe static InlineArray26_SByte* Pointer => unchecked((InlineArray26_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray26_SByte Value
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

	unsafe static String_d9apgb()
	{
		Value = InlineArrayHelper.Create<InlineArray26_SByte, byte>("find_all_matches_callback\0"u8);
		PointerIndices.Register(Pointer);
	}
}
